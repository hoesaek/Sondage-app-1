namespace AppSondage
{
    partial class FinSondage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinSondage));
            this.pnlBotD = new System.Windows.Forms.Panel();
            this.pnlinBotD = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.TimeDebutNouveauSond = new System.Windows.Forms.Timer(this.components);
            this.pnlBotD.SuspendLayout();
            this.pnlinBotD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotD
            // 
            this.pnlBotD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.pnlBotD.Controls.Add(this.pnlinBotD);
            this.pnlBotD.Location = new System.Drawing.Point(22, 36);
            this.pnlBotD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBotD.Name = "pnlBotD";
            this.pnlBotD.Size = new System.Drawing.Size(629, 333);
            this.pnlBotD.TabIndex = 16;
            // 
            // pnlinBotD
            // 
            this.pnlinBotD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlinBotD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(188)))), ((int)(((byte)(96)))));
            this.pnlinBotD.Controls.Add(this.lblMessage);
            this.pnlinBotD.Location = new System.Drawing.Point(-7, 76);
            this.pnlinBotD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlinBotD.Name = "pnlinBotD";
            this.pnlinBotD.Size = new System.Drawing.Size(646, 184);
            this.pnlinBotD.TabIndex = 7;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(7, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(626, 184);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Le sondage est à présent terminé  \r\nRevenez lorsqu\'un sondage sera chargé  !!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // TimeDebutNouveauSond
            // 
            this.TimeDebutNouveauSond.Interval = 1000;
            // 
            // FinSondage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 439);
            this.Controls.Add(this.pnlBotD);
            this.Enabled = false;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinSondage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinSondage";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FinSondage_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FinSondage_Load);
            this.pnlBotD.ResumeLayout(false);
            this.pnlinBotD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBotD;
        private Panel pnlinBotD;
        private Label lblMessage;
        private System.Windows.Forms.Timer TimeDebutNouveauSond;
    }
}