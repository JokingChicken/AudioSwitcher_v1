using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FortyOne.AudioSwitcher.Configuration;

namespace FortyOne.AudioSwitcher.HotKeyData
{
    public static class HotKeyManager
    {
        private static readonly List<HotKey> _hotkeys = new List<HotKey>();
        public static BindingList<HotKey> HotKeys = new BindingList<HotKey>();

        static HotKeyManager()
        {
            LoadHotKeys();
            RefreshHotkeys();
        }

        public static event EventHandler HotKeyPressed;

        public static void ClearAll()
        {
            foreach (var hk in _hotkeys)
            {
                hk.UnregisterHotkey();
            }

            Program.Settings.HotKeys = "";
            LoadHotKeys();
            RefreshHotkeys();
        }

        public static void LoadHotKeys()
        {
            try
            {
                foreach (var hk in _hotkeys)
                {
                    hk.UnregisterHotkey();
                }

                _hotkeys.Clear();

                var hotkeydata = Program.Settings.HotKeys;
                if (string.IsNullOrEmpty(hotkeydata))
                {
                    RefreshHotkeys();
                    return;
                }

                var entries = hotkeydata.Split(new[] { ",", "[", "]" }, StringSplitOptions.RemoveEmptyEntries);

                for (var i = 0; i < entries.Length; i += 4)
                {
                    var key = int.Parse(entries[i]);
                    var modifiers = int.Parse(entries[i+1]);

                    var device1 = entries[i+2].ToString();
                    var device2 = entries[i + 3].ToString();

                    var hk = new HotKey();

                    var r = new Regex(ConfigurationSettings.GUID_REGEX);
                    // here we check if the string is valid Guid
                    if (!r.Match(device1).Success) continue;
                    if (!r.Match(device2).Success) device2 = Guid.Empty.ToString();

                    hk.DeviceId = new Guid(device1);
                    hk.ToggleDeviceID = new Guid(device2);

                    hk.Modifiers = (Modifiers)modifiers;
                    hk.Key = (Keys)key;

                    _hotkeys.Add(hk);

                    hk.HotKeyPressed += hk_HotKeyPressed;
                    hk.RegisterHotkey();
                }
            }
            catch
            {
                Program.Settings.HotKeys = ""; // TODO: DanJ: maybe try to recover, instead of removing whole storage object
            }
        }

        private static void hk_HotKeyPressed(object sender, EventArgs e)
        {
            if (HotKeyPressed != null)
                HotKeyPressed(sender, e);
        }

        public static void SaveHotKeys()
        {
            var hotkeydata = "";
            foreach (var hk in _hotkeys)
            {
                hotkeydata += "[" + (int)hk.Key + "," + (int)hk.Modifiers + "," + hk.DeviceId + "," + hk.ToggleDeviceID.ToString() + "]";
            }
            Program.Settings.HotKeys = hotkeydata;

            RefreshHotkeys();
        }

        public static bool AddHotKey(HotKey hk)
        {
            //Check that there is no duplicate
            if (DuplicateHotKey(hk))
                return false;

            hk.HotKeyPressed += hk_HotKeyPressed;
            hk.RegisterHotkey();

            if (!hk.IsRegistered)
                return false;

            _hotkeys.Add(hk);

            SaveHotKeys();
            return true;
        }

        public static void RefreshHotkeys()
        {
            HotKeys.Clear();
            var filterInvalid = !Program.Settings.ShowUnknownDevicesInHotkeyList;
            IEnumerable<HotKey> hotkeyList = _hotkeys;
            if (filterInvalid)
                hotkeyList = hotkeyList.Where(x => x.Device != null);
            
            foreach (var k in hotkeyList)
            {
                HotKeys.Add(k);
            }
        }

        public static bool DuplicateHotKey(HotKey hk)
        {
            return _hotkeys.Any(k => hk.Key == k.Key && hk.Modifiers == k.Modifiers);
        }

        public static void DeleteHotKey(HotKey hk)
        {
            //Ensure its unregistered
            hk.UnregisterHotkey();
            _hotkeys.Remove(hk);
            SaveHotKeys();
        }
    }
}