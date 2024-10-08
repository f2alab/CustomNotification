﻿namespace F2a_Notification
{
    partial class Notification
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
            this.PanelTitrePrincipal = new System.Windows.Forms.Panel();
            this.PanelTitre0 = new System.Windows.Forms.Panel();
            this.LabelTitre = new System.Windows.Forms.Label();
            this.ProgressBarTemps = new System.Windows.Forms.ProgressBar();
            this.PanelIcon = new System.Windows.Forms.Panel();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.TimerAnim = new System.Windows.Forms.Timer(this.components);
            this.TimerTemps = new System.Windows.Forms.Timer(this.components);
            this.TimerDisparition = new System.Windows.Forms.Timer(this.components);
            this.PanelBarre = new System.Windows.Forms.Panel();
            this.PanelMessage = new System.Windows.Forms.Panel();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.PanelTitrePrincipal.SuspendLayout();
            this.PanelTitre0.SuspendLayout();
            this.PanelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.PanelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitrePrincipal
            // 
            this.PanelTitrePrincipal.Controls.Add(this.PanelTitre0);
            this.PanelTitrePrincipal.Controls.Add(this.PanelIcon);
            this.PanelTitrePrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitrePrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelTitrePrincipal.Name = "PanelTitrePrincipal";
            this.PanelTitrePrincipal.Size = new System.Drawing.Size(162, 30);
            this.PanelTitrePrincipal.TabIndex = 3;
            // 
            // PanelTitre0
            // 
            this.PanelTitre0.AutoSize = true;
            this.PanelTitre0.Controls.Add(this.ProgressBarTemps);
            this.PanelTitre0.Controls.Add(this.LabelTitre);
            this.PanelTitre0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTitre0.Location = new System.Drawing.Point(34, 0);
            this.PanelTitre0.Name = "PanelTitre0";
            this.PanelTitre0.Size = new System.Drawing.Size(128, 30);
            this.PanelTitre0.TabIndex = 1;
            // 
            // LabelTitre
            // 
            this.LabelTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitre.AutoEllipsis = true;
            this.LabelTitre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitre.Location = new System.Drawing.Point(3, 5);
            this.LabelTitre.Name = "LabelTitre";
            this.LabelTitre.Size = new System.Drawing.Size(117, 21);
            this.LabelTitre.TabIndex = 1;
            this.LabelTitre.Text = "TITRE";
            this.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelTitre.MouseEnter += new System.EventHandler(this.LabelTitre_MouseEnter);
            this.LabelTitre.MouseLeave += new System.EventHandler(this.LabelTitre_MouseLeave);
            this.LabelTitre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelTitre_MouseUp);
            // 
            // ProgressBarTemps
            // 
            this.ProgressBarTemps.Location = new System.Drawing.Point(72, 11);
            this.ProgressBarTemps.Name = "ProgressBarTemps";
            this.ProgressBarTemps.Size = new System.Drawing.Size(62, 13);
            this.ProgressBarTemps.TabIndex = 2;
            this.ProgressBarTemps.Visible = false;
            // 
            // PanelIcon
            // 
            this.PanelIcon.Controls.Add(this.PictureBoxIcon);
            this.PanelIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIcon.Location = new System.Drawing.Point(0, 0);
            this.PanelIcon.MinimumSize = new System.Drawing.Size(34, 35);
            this.PanelIcon.Name = "PanelIcon";
            this.PanelIcon.Size = new System.Drawing.Size(34, 35);
            this.PanelIcon.TabIndex = 0;
            this.PanelIcon.MouseEnter += new System.EventHandler(this.PanelIcon_MouseEnter);
            this.PanelIcon.MouseLeave += new System.EventHandler(this.PanelIcon_MouseLeave);
            this.PanelIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelIcon_MouseUp);
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxIcon.Image = global::F2a_Notification.Properties.Resources.Done_26px;
            this.PictureBoxIcon.Location = new System.Drawing.Point(5, 3);
            this.PictureBoxIcon.MaximumSize = new System.Drawing.Size(25, 25);
            this.PictureBoxIcon.MinimumSize = new System.Drawing.Size(25, 25);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxIcon.TabIndex = 0;
            this.PictureBoxIcon.TabStop = false;
            this.PictureBoxIcon.MouseEnter += new System.EventHandler(this.PictureBoxIcon_MouseEnter);
            this.PictureBoxIcon.MouseLeave += new System.EventHandler(this.PictureBoxIcon_MouseLeave);
            this.PictureBoxIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxIcon_MouseUp);
            // 
            // TimerAnim
            // 
            this.TimerAnim.Enabled = true;
            this.TimerAnim.Interval = 50;
            this.TimerAnim.Tick += new System.EventHandler(this.TimerSlideAnim_Tick);
            // 
            // TimerTemps
            // 
            this.TimerTemps.Interval = 300;
            this.TimerTemps.Tick += new System.EventHandler(this.TimerTemps_Tick);
            // 
            // TimerDisparition
            // 
            this.TimerDisparition.Tick += new System.EventHandler(this.TimerDisparition_Tick);
            // 
            // PanelBarre
            // 
            this.PanelBarre.BackColor = System.Drawing.Color.White;
            this.PanelBarre.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarre.Location = new System.Drawing.Point(0, 30);
            this.PanelBarre.Name = "PanelBarre";
            this.PanelBarre.Size = new System.Drawing.Size(162, 5);
            this.PanelBarre.TabIndex = 4;
            this.PanelBarre.MouseEnter += new System.EventHandler(this.PanelBarre_MouseEnter);
            this.PanelBarre.MouseLeave += new System.EventHandler(this.PanelBarre_MouseLeave);
            this.PanelBarre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelBarre_MouseUp);
            // 
            // PanelMessage
            // 
            this.PanelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMessage.AutoSize = true;
            this.PanelMessage.Controls.Add(this.LabelMessage);
            this.PanelMessage.Location = new System.Drawing.Point(0, 35);
            this.PanelMessage.Name = "PanelMessage";
            this.PanelMessage.Size = new System.Drawing.Size(260, 68);
            this.PanelMessage.TabIndex = 7;
            // 
            // LabelMessage
            // 
            this.LabelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMessage.AutoEllipsis = true;
            this.LabelMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.Location = new System.Drawing.Point(0, 3);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Padding = new System.Windows.Forms.Padding(8, 5, 8, 8);
            this.LabelMessage.Size = new System.Drawing.Size(162, 36);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "Message command.ExecuteNonQueryAsync(); command.ExecuteNonQueryAsync();command.Ex" +
    "ecuteNonQueryAsync();command.ExecuteNonQueryAsync();command.ExecuteNonQueryAsync" +
    "();";
            this.LabelMessage.MouseEnter += new System.EventHandler(this.LabelMessage_MouseEnter);
            this.LabelMessage.MouseLeave += new System.EventHandler(this.LabelMessage_MouseLeave);
            this.LabelMessage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelMessage_MouseUp);
            // 
            // Notification
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(162, 74);
            this.Controls.Add(this.PanelMessage);
            this.Controls.Add(this.PanelBarre);
            this.Controls.Add(this.PanelTitrePrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notification";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Notification_Load);
            this.PanelTitrePrincipal.ResumeLayout(false);
            this.PanelTitrePrincipal.PerformLayout();
            this.PanelTitre0.ResumeLayout(false);
            this.PanelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.PanelMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitrePrincipal;
        private System.Windows.Forms.Timer TimerAnim;
        private System.Windows.Forms.Timer TimerTemps;
        private System.Windows.Forms.Timer TimerDisparition;
        private System.Windows.Forms.Panel PanelIcon;
        private System.Windows.Forms.Panel PanelTitre0;
        private System.Windows.Forms.ProgressBar ProgressBarTemps;
        private System.Windows.Forms.Label LabelTitre;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Panel PanelBarre;
        private System.Windows.Forms.Panel PanelMessage;
        private System.Windows.Forms.Label LabelMessage;
    }
}