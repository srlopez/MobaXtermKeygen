using System.ComponentModel;

namespace MobaXterm_Keygen
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnActivate = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.majorVersion = new System.Windows.Forms.NumericUpDown();
            this.minorVersion = new System.Windows.Forms.NumericUpDown();
            this.users = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetVersion = new System.Windows.Forms.Button();
            this.licenseComboBox = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.majorVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(241, 46);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(118, 28);
            this.btnActivate.TabIndex = 0;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(88, 12);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 1;
            this.txtBoxName.Text = "derech1e";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Licensetype";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Version";
            // 
            // majorVersion
            // 
            this.majorVersion.Location = new System.Drawing.Point(88, 65);
            this.majorVersion.Name = "majorVersion";
            this.majorVersion.Size = new System.Drawing.Size(57, 20);
            this.majorVersion.TabIndex = 6;
            this.majorVersion.Value = new decimal(new int[] { 22, 0, 0, 0 });
            // 
            // minorVersion
            // 
            this.minorVersion.Location = new System.Drawing.Point(151, 65);
            this.minorVersion.Name = "minorVersion";
            this.minorVersion.Size = new System.Drawing.Size(57, 20);
            this.minorVersion.TabIndex = 7;
            this.minorVersion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // users
            // 
            this.users.Location = new System.Drawing.Point(88, 91);
            this.users.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this.users.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(57, 20);
            this.users.TabIndex = 8;
            this.users.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Users";
            // 
            // btnGetVersion
            // 
            this.btnGetVersion.Location = new System.Drawing.Point(241, 80);
            this.btnGetVersion.Name = "btnGetVersion";
            this.btnGetVersion.Size = new System.Drawing.Size(118, 28);
            this.btnGetVersion.TabIndex = 10;
            this.btnGetVersion.Text = "Get Version from File";
            this.btnGetVersion.UseVisualStyleBackColor = true;
            this.btnGetVersion.Click += new System.EventHandler(this.btnGetVersion_Click);
            // 
            // licenseComboBox
            // 
            this.licenseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.licenseComboBox.FormattingEnabled = true;
            this.licenseComboBox.Items.AddRange(new object[] { "Professional", "Educational", "Personal" });
            this.licenseComboBox.Location = new System.Drawing.Point(88, 38);
            this.licenseComboBox.Name = "licenseComboBox";
            this.licenseComboBox.Size = new System.Drawing.Size(121, 21);
            this.licenseComboBox.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(241, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 122);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.licenseComboBox);
            this.Controls.Add(this.btnGetVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.users);
            this.Controls.Add(this.minorVersion);
            this.Controls.Add(this.majorVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnActivate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "MobaXterm Keygen by derech1e";
            ((System.ComponentModel.ISupportInitialize)(this.majorVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.ComboBox licenseComboBox;

        private System.Windows.Forms.Button btnGetVersion;

        private System.Windows.Forms.NumericUpDown majorVersion;
        private System.Windows.Forms.NumericUpDown minorVersion;
        private System.Windows.Forms.NumericUpDown users;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnActivate;

        #endregion
    }
}