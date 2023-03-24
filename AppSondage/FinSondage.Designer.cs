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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinSondage));
            infoSondage = new Label();
            infocomplementaire = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // infoSondage
            // 
            infoSondage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoSondage.AutoSize = true;
            infoSondage.Font = new Font("Yu Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            infoSondage.Location = new Point(126, 111);
            infoSondage.Name = "infoSondage";
            infoSondage.Size = new Size(434, 43);
            infoSondage.TabIndex = 0;
            infoSondage.Text = "Aucun sondage en cours...";
            infoSondage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // infocomplementaire
            // 
            infocomplementaire.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infocomplementaire.AutoSize = true;
            infocomplementaire.Location = new Point(109, 196);
            infocomplementaire.Name = "infocomplementaire";
            infocomplementaire.Size = new Size(491, 20);
            infocomplementaire.TabIndex = 1;
            infocomplementaire.Text = "Nous sommes actuellement en cours de creation d'un nouveau sondage !";
            infocomplementaire.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(220, 227);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 2;
            label1.Text = "Nous serons bientôt de retour !!";
            // 
            // FinSondage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(171, 209, 198);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(696, 439);
            Controls.Add(label1);
            Controls.Add(infocomplementaire);
            Controls.Add(infoSondage);
            Cursor = Cursors.WaitCursor;
            Enabled = false;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "FinSondage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinSondage";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            HelpButtonClicked += FinSondage_HelpButtonClicked;
            Load += FinSondage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoSondage;
        private Label infocomplementaire;
        private Label label1;
    }
}