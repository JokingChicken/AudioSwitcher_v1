namespace FortyOne.AudioSwitcher
{
    partial class HotKeyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.togglecmbDevices = new System.Windows.Forms.ComboBox();
            this.txtHotKey = new System.Windows.Forms.TextBox();
            this.cbtoggle = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDevices
            // 
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.DropDownWidth = 300;
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(62, 12);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(159, 21);
            this.cmbDevices.TabIndex = 0;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // togglecmbDevices
            // 
            this.togglecmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.togglecmbDevices.DropDownWidth = 300;
            this.togglecmbDevices.FormattingEnabled = true;
            this.togglecmbDevices.Location = new System.Drawing.Point(81, 66);
            this.togglecmbDevices.Name = "togglecmbDevices";
            this.togglecmbDevices.Size = new System.Drawing.Size(140, 21);
            this.togglecmbDevices.TabIndex = 3;
            this.togglecmbDevices.Visible = false;
            this.togglecmbDevices.SelectedIndexChanged += new System.EventHandler(this.togglecmbDevices_SelectedIndexChanged);
            // 
            // txtHotKey
            // 
            this.txtHotKey.Location = new System.Drawing.Point(62, 39);
            this.txtHotKey.Name = "txtHotKey";
            this.txtHotKey.ReadOnly = true;
            this.txtHotKey.Size = new System.Drawing.Size(159, 20);
            this.txtHotKey.TabIndex = 1;
            this.txtHotKey.Text = "Mimic Hot Key In Here";
            this.txtHotKey.Enter += new System.EventHandler(this.txtHotKey_Enter);
            this.txtHotKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHotKey_KeyUp);
            // 
            // cbtoggle
            // 
            this.cbtoggle.Location = new System.Drawing.Point(61, 70);
            this.cbtoggle.Name = "cbtoggle";
            this.cbtoggle.Size = new System.Drawing.Size(14, 13);
            this.cbtoggle.TabIndex = 2;
            this.cbtoggle.CheckedChanged += new System.EventHandler(this.cbtoggle_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(171, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hot Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toggle:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HotKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbtoggle);
            this.Controls.Add(this.txtHotKey);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.togglecmbDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotKeyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Hot Key";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotKeyForm_FormClosed);
            this.Load += new System.EventHandler(this.HotKeyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.TextBox txtHotKey;
        private System.Windows.Forms.CheckBox cbtoggle;
        private System.Windows.Forms.ComboBox togglecmbDevices;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}