using System.Windows.Forms;

namespace EposSystem
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.PnlMain = new System.Windows.Forms.Panel();
            this.lblLisence = new System.Windows.Forms.Label();
            this.lblLabel2 = new System.Windows.Forms.Label();
            this.lblIogo1 = new System.Windows.Forms.Label();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.LblLoadingMsgs = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlMain.Controls.Add(this.lblLisence);
            this.PnlMain.Controls.Add(this.lblLabel2);
            this.PnlMain.Controls.Add(this.lblIogo1);
            this.PnlMain.Controls.Add(this.PBIcon);
            this.PnlMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnlMain.Location = new System.Drawing.Point(17, 17);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(583, 347);
            this.PnlMain.TabIndex = 0;
            // 
            // lblLisence
            // 
            this.lblLisence.AutoSize = true;
            this.lblLisence.Location = new System.Drawing.Point(17, 325);
            this.lblLisence.Name = "lblLisence";
            this.lblLisence.Size = new System.Drawing.Size(126, 13);
            this.lblLisence.TabIndex = 3;
            this.lblLisence.Text = "Licensed To: McDonalds";
            // 
            // lblLabel2
            // 
            this.lblLabel2.AutoSize = true;
            this.lblLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLabel2.Location = new System.Drawing.Point(349, 218);
            this.lblLabel2.Name = "lblLabel2";
            this.lblLabel2.Size = new System.Drawing.Size(91, 30);
            this.lblLabel2.TabIndex = 2;
            this.lblLabel2.Text = "Systems";
            // 
            // lblIogo1
            // 
            this.lblIogo1.AutoSize = true;
            this.lblIogo1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold);
            this.lblIogo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIogo1.Location = new System.Drawing.Point(39, 107);
            this.lblIogo1.Name = "lblIogo1";
            this.lblIogo1.Size = new System.Drawing.Size(514, 128);
            this.lblIogo1.TabIndex = 1;
            this.lblIogo1.Text = "Kongolian";
            // 
            // PBIcon
            // 
            this.PBIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBIcon.Image = global::EposSystem.Properties.Resources.Icon;
            this.PBIcon.Location = new System.Drawing.Point(17, 17);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(86, 87);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 0;
            this.PBIcon.TabStop = false;
            // 
            // LblLoadingMsgs
            // 
            this.LblLoadingMsgs.AutoSize = true;
            this.LblLoadingMsgs.Location = new System.Drawing.Point(34, 380);
            this.LblLoadingMsgs.Name = "LblLoadingMsgs";
            this.LblLoadingMsgs.Size = new System.Drawing.Size(75, 13);
            this.LblLoadingMsgs.TabIndex = 1;
            this.LblLoadingMsgs.Text = "Loading Users";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(531, 380);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(72, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version: 1.0.0";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(617, 416);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.LblLoadingMsgs);
            this.Controls.Add(this.PnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartUp";
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PnlMain;
        private Label lblLabel2;
        private Label lblIogo1;
        private PictureBox PBIcon;
        private Label lblLisence;
        private Label LblLoadingMsgs;
        private Label lblVersion;
    }
}