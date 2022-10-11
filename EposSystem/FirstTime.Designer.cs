using System.Windows.Forms;

namespace EposSystem
{
    partial class FirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTime));
            this.label1 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBOrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBBranch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            this.LblCode = new System.Windows.Forms.Label();
            this.TBCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(91, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initializing Kongolian Systems, Please Fill Spaces Provided.";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.TBName.Location = new System.Drawing.Point(107, 111);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(500, 27);
            this.TBName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(316, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // PBIcon
            // 
            this.PBIcon.Image = global::EposSystem.Properties.Resources.Icon;
            this.PBIcon.Location = new System.Drawing.Point(10, 10);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(75, 75);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 3;
            this.PBIcon.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(283, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Organization";
            // 
            // TBOrg
            // 
            this.TBOrg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.TBOrg.Location = new System.Drawing.Point(107, 174);
            this.TBOrg.Name = "TBOrg";
            this.TBOrg.Size = new System.Drawing.Size(500, 27);
            this.TBOrg.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(313, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Branch";
            // 
            // TBBranch
            // 
            this.TBBranch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.TBBranch.Location = new System.Drawing.Point(106, 237);
            this.TBBranch.Name = "TBBranch";
            this.TBBranch.Size = new System.Drawing.Size(500, 27);
            this.TBBranch.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(316, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.TBEmail.Location = new System.Drawing.Point(106, 300);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(500, 27);
            this.TBEmail.TabIndex = 10;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSubmit.Location = new System.Drawing.Point(106, 396);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(500, 42);
            this.BtnSubmit.TabIndex = 12;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblError.ForeColor = System.Drawing.Color.IndianRed;
            this.LblError.Location = new System.Drawing.Point(119, 441);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(324, 25);
            this.LblError.TabIndex = 13;
            this.LblError.Text = "Please make sure all data is correct!";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCode.Location = new System.Drawing.Point(156, 330);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(135, 30);
            this.LblCode.TabIndex = 15;
            this.LblCode.Text = "Admin Code";
            // 
            // TBCode
            // 
            this.TBCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.TBCode.Location = new System.Drawing.Point(107, 363);
            this.TBCode.MaxLength = 4;
            this.TBCode.Name = "TBCode";
            this.TBCode.Size = new System.Drawing.Size(233, 27);
            this.TBCode.TabIndex = 14;
            this.TBCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCode_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(437, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pin Code";
            // 
            // TBPassword
            // 
            this.TBPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.TBPassword.Location = new System.Drawing.Point(346, 363);
            this.TBPassword.MaxLength = 10;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(260, 27);
            this.TBPassword.TabIndex = 16;
            this.TBPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPassword_KeyPress);
            // 
            // FirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.TBCode);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBBranch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBOrg);
            this.Controls.Add(this.PBIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstTime";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TBName;
        private Label label2;
        private PictureBox PBIcon;
        private Label label3;
        private TextBox TBOrg;
        private Label label4;
        private TextBox TBBranch;
        private Label label5;
        private TextBox TBEmail;
        private Button BtnSubmit;
        private Label LblError;
        private Label LblCode;
        private TextBox TBCode;
        private Label label7;
        private TextBox TBPassword;
    }
}