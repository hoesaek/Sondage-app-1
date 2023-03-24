namespace AppSondage
{
    partial class ConnPortCOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnPortCOM));
            groupBox1 = new GroupBox();
            cbPB = new ComboBox();
            cbSB = new ComboBox();
            cbDB = new ComboBox();
            cbBR = new ComboBox();
            cbCOM = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClose = new Button();
            btnOpen = new Button();
            progressBar1 = new ProgressBar();
            btnAnnuler = new Button();
            btnSuivant = new Button();
            lblOnOff = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbPB);
            groupBox1.Controls.Add(cbSB);
            groupBox1.Controls.Add(cbDB);
            groupBox1.Controls.Add(cbBR);
            groupBox1.Controls.Add(cbCOM);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 135);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(230, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Set Port COM";
            // 
            // cbPB
            // 
            cbPB.FormattingEnabled = true;
            cbPB.Items.AddRange(new object[] { "None", "Odd", "Even" });
            cbPB.Location = new Point(79, 224);
            cbPB.Margin = new Padding(3, 4, 3, 4);
            cbPB.Name = "cbPB";
            cbPB.Size = new Size(126, 28);
            cbPB.TabIndex = 9;
            cbPB.Text = "None";
            // 
            // cbSB
            // 
            cbSB.ForeColor = Color.Black;
            cbSB.FormattingEnabled = true;
            cbSB.Items.AddRange(new object[] { "One", "Two" });
            cbSB.Location = new Point(79, 177);
            cbSB.Margin = new Padding(3, 4, 3, 4);
            cbSB.Name = "cbSB";
            cbSB.Size = new Size(126, 28);
            cbSB.TabIndex = 8;
            cbSB.Text = "One";
            // 
            // cbDB
            // 
            cbDB.ForeColor = Color.Black;
            cbDB.FormattingEnabled = true;
            cbDB.Items.AddRange(new object[] { "6", "7", "8" });
            cbDB.Location = new Point(79, 131);
            cbDB.Margin = new Padding(3, 4, 3, 4);
            cbDB.Name = "cbDB";
            cbDB.Size = new Size(126, 28);
            cbDB.TabIndex = 7;
            cbDB.Text = "8";
            // 
            // cbBR
            // 
            cbBR.ForeColor = Color.Black;
            cbBR.FormattingEnabled = true;
            cbBR.Items.AddRange(new object[] { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400" });
            cbBR.Location = new Point(79, 84);
            cbBR.Margin = new Padding(3, 4, 3, 4);
            cbBR.Name = "cbBR";
            cbBR.Size = new Size(126, 28);
            cbBR.TabIndex = 6;
            cbBR.Text = "9600";
            cbBR.SelectedIndexChanged += cbBR_SelectedIndexChanged;
            // 
            // cbCOM
            // 
            cbCOM.FormattingEnabled = true;
            cbCOM.Location = new Point(79, 37);
            cbCOM.Margin = new Padding(3, 4, 3, 4);
            cbCOM.Name = "cbCOM";
            cbCOM.Size = new Size(126, 28);
            cbCOM.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 224);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Parity Bits";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 177);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Stop Bits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 131);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Data Bits";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 84);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Baud Rate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "COM Port";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Location = new Point(12, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(231, 107);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(129, 25);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(78, 31);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(7, 25);
            btnOpen.Margin = new Padding(3, 4, 3, 4);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(78, 31);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(9, 64);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(199, 27);
            progressBar1.TabIndex = 2;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(261, 221);
            btnAnnuler.Margin = new Padding(3, 4, 3, 4);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(85, 28);
            btnAnnuler.TabIndex = 4;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnSuivant
            // 
            btnSuivant.Location = new Point(261, 185);
            btnSuivant.Margin = new Padding(3, 4, 3, 4);
            btnSuivant.Name = "btnSuivant";
            btnSuivant.Size = new Size(85, 28);
            btnSuivant.TabIndex = 5;
            btnSuivant.Text = "Suivant";
            btnSuivant.UseVisualStyleBackColor = true;
            btnSuivant.Click += btnSuivant_Click;
            // 
            // lblOnOff
            // 
            lblOnOff.AutoSize = true;
            lblOnOff.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOnOff.Location = new Point(273, 135);
            lblOnOff.Name = "lblOnOff";
            lblOnOff.Size = new Size(56, 34);
            lblOnOff.TabIndex = 6;
            lblOnOff.Text = "Off";
            // 
            // ConnPortCOM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 423);
            Controls.Add(lblOnOff);
            Controls.Add(btnSuivant);
            Controls.Add(btnAnnuler);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConnPortCOM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion PortCOM";
            Load += ConnPortCOM_Load;
            Resize += ConnPortCOM_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cbPB;
        private ComboBox cbSB;
        private ComboBox cbDB;
        private ComboBox cbBR;
        private ComboBox cbCOM;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private Button btnAnnuler;
        private Button btnSuivant;
        private Label lblOnOff;
        private Button btnClose;
        private Button btnOpen;
    }
}