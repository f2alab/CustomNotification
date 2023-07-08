namespace F2a_Notification
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.RCBtn = new System.Windows.Forms.Button();
            this.TRBtn = new System.Windows.Forms.Button();
            this.TCBtn = new System.Windows.Forms.Button();
            this.TLBtn = new System.Windows.Forms.Button();
            this.LCBtn = new System.Windows.Forms.Button();
            this.BCBtn = new System.Windows.Forms.Button();
            this.LBBtn = new System.Windows.Forms.Button();
            this.RBBtn = new System.Windows.Forms.Button();
            this.CSBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RCBtn
            // 
            this.RCBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RCBtn.Location = new System.Drawing.Point(485, 122);
            this.RCBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RCBtn.Name = "RCBtn";
            this.RCBtn.Size = new System.Drawing.Size(121, 29);
            this.RCBtn.TabIndex = 0;
            this.RCBtn.Text = "Notification RC";
            this.RCBtn.UseVisualStyleBackColor = true;
            this.RCBtn.Click += new System.EventHandler(this.RCBtn_Click);
            // 
            // TRBtn
            // 
            this.TRBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TRBtn.Location = new System.Drawing.Point(485, 12);
            this.TRBtn.Name = "TRBtn";
            this.TRBtn.Size = new System.Drawing.Size(121, 35);
            this.TRBtn.TabIndex = 4;
            this.TRBtn.Text = "Notification TR";
            this.TRBtn.UseVisualStyleBackColor = true;
            this.TRBtn.Click += new System.EventHandler(this.TRBtn_Click);
            // 
            // TCBtn
            // 
            this.TCBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TCBtn.Location = new System.Drawing.Point(237, 12);
            this.TCBtn.Name = "TCBtn";
            this.TCBtn.Size = new System.Drawing.Size(127, 35);
            this.TCBtn.TabIndex = 5;
            this.TCBtn.Text = "Notification TC";
            this.TCBtn.UseVisualStyleBackColor = true;
            this.TCBtn.Click += new System.EventHandler(this.TCBtn_Click);
            // 
            // TLBtn
            // 
            this.TLBtn.Location = new System.Drawing.Point(12, 12);
            this.TLBtn.Name = "TLBtn";
            this.TLBtn.Size = new System.Drawing.Size(127, 35);
            this.TLBtn.TabIndex = 5;
            this.TLBtn.Text = "Notification TL";
            this.TLBtn.UseVisualStyleBackColor = true;
            this.TLBtn.Click += new System.EventHandler(this.TLBtn_Click);
            // 
            // LCBtn
            // 
            this.LCBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LCBtn.Location = new System.Drawing.Point(12, 116);
            this.LCBtn.Name = "LCBtn";
            this.LCBtn.Size = new System.Drawing.Size(127, 35);
            this.LCBtn.TabIndex = 5;
            this.LCBtn.Text = "Notification LC";
            this.LCBtn.UseVisualStyleBackColor = true;
            this.LCBtn.Click += new System.EventHandler(this.LCBtn_Click);
            // 
            // BCBtn
            // 
            this.BCBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BCBtn.Location = new System.Drawing.Point(237, 217);
            this.BCBtn.Name = "BCBtn";
            this.BCBtn.Size = new System.Drawing.Size(127, 35);
            this.BCBtn.TabIndex = 5;
            this.BCBtn.Text = "Notification BC";
            this.BCBtn.UseVisualStyleBackColor = true;
            this.BCBtn.Click += new System.EventHandler(this.BCBtn_Click);
            // 
            // LBBtn
            // 
            this.LBBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBBtn.Location = new System.Drawing.Point(12, 217);
            this.LBBtn.Name = "LBBtn";
            this.LBBtn.Size = new System.Drawing.Size(127, 35);
            this.LBBtn.TabIndex = 5;
            this.LBBtn.Text = "Notification LB";
            this.LBBtn.UseVisualStyleBackColor = true;
            this.LBBtn.Click += new System.EventHandler(this.LBBtn_Click);
            // 
            // RBBtn
            // 
            this.RBBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBBtn.Location = new System.Drawing.Point(478, 217);
            this.RBBtn.Name = "RBBtn";
            this.RBBtn.Size = new System.Drawing.Size(127, 35);
            this.RBBtn.TabIndex = 5;
            this.RBBtn.Text = "Notification RB";
            this.RBBtn.UseVisualStyleBackColor = true;
            this.RBBtn.Click += new System.EventHandler(this.RBBtn_Click);
            // 
            // CSBtn
            // 
            this.CSBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CSBtn.Location = new System.Drawing.Point(237, 113);
            this.CSBtn.Name = "CSBtn";
            this.CSBtn.Size = new System.Drawing.Size(127, 35);
            this.CSBtn.TabIndex = 5;
            this.CSBtn.Text = "Notification LC";
            this.CSBtn.UseVisualStyleBackColor = true;
            this.CSBtn.Click += new System.EventHandler(this.CSBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 264);
            this.Controls.Add(this.LBBtn);
            this.Controls.Add(this.RBBtn);
            this.Controls.Add(this.BCBtn);
            this.Controls.Add(this.CSBtn);
            this.Controls.Add(this.LCBtn);
            this.Controls.Add(this.TLBtn);
            this.Controls.Add(this.TCBtn);
            this.Controls.Add(this.TRBtn);
            this.Controls.Add(this.RCBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Notification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RCBtn;
        private System.Windows.Forms.Button TRBtn;
        private System.Windows.Forms.Button TCBtn;
        private System.Windows.Forms.Button TLBtn;
        private System.Windows.Forms.Button LCBtn;
        private System.Windows.Forms.Button BCBtn;
        private System.Windows.Forms.Button LBBtn;
        private System.Windows.Forms.Button RBBtn;
        private System.Windows.Forms.Button CSBtn;
    }
}

