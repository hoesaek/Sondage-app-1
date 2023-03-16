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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPB = new System.Windows.Forms.ComboBox();
            this.cbSB = new System.Windows.Forms.ComboBox();
            this.cbDB = new System.Windows.Forms.ComboBox();
            this.cbBR = new System.Windows.Forms.ComboBox();
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.lblOnOff = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPB);
            this.groupBox1.Controls.Add(this.cbSB);
            this.groupBox1.Controls.Add(this.cbDB);
            this.groupBox1.Controls.Add(this.cbBR);
            this.groupBox1.Controls.Add(this.cbCOM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(201, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Port COM";
            // 
            // cbPB
            // 
            this.cbPB.FormattingEnabled = true;
            this.cbPB.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbPB.Location = new System.Drawing.Point(69, 168);
            this.cbPB.Name = "cbPB";
            this.cbPB.Size = new System.Drawing.Size(111, 23);
            this.cbPB.TabIndex = 9;
            this.cbPB.Text = "None";
            // 
            // cbSB
            // 
            this.cbSB.ForeColor = System.Drawing.Color.Black;
            this.cbSB.FormattingEnabled = true;
            this.cbSB.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbSB.Location = new System.Drawing.Point(69, 133);
            this.cbSB.Name = "cbSB";
            this.cbSB.Size = new System.Drawing.Size(111, 23);
            this.cbSB.TabIndex = 8;
            this.cbSB.Text = "One";
            // 
            // cbDB
            // 
            this.cbDB.ForeColor = System.Drawing.Color.Black;
            this.cbDB.FormattingEnabled = true;
            this.cbDB.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDB.Location = new System.Drawing.Point(69, 98);
            this.cbDB.Name = "cbDB";
            this.cbDB.Size = new System.Drawing.Size(111, 23);
            this.cbDB.TabIndex = 7;
            this.cbDB.Text = "8";
            // 
            // cbBR
            // 
            this.cbBR.ForeColor = System.Drawing.Color.Black;
            this.cbBR.FormattingEnabled = true;
            this.cbBR.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400"});
            this.cbBR.Location = new System.Drawing.Point(69, 63);
            this.cbBR.Name = "cbBR";
            this.cbBR.Size = new System.Drawing.Size(111, 23);
            this.cbBR.TabIndex = 6;
            this.cbBR.Text = "9600";
            this.cbBR.SelectedIndexChanged += new System.EventHandler(this.cbBR_SelectedIndexChanged);
            // 
            // cbCOM
            // 
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Location = new System.Drawing.Point(69, 28);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(111, 23);
            this.cbCOM.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(9, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(113, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(68, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(174, 20);
            this.progressBar1.TabIndex = 2;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(229, 272);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(74, 21);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(229, 245);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(74, 21);
            this.btnSuivant.TabIndex = 5;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // lblOnOff
            // 
            this.lblOnOff.AutoSize = true;
            this.lblOnOff.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOnOff.Location = new System.Drawing.Point(240, 208);
            this.lblOnOff.Name = "lblOnOff";
            this.lblOnOff.Size = new System.Drawing.Size(43, 28);
            this.lblOnOff.TabIndex = 6;
            this.lblOnOff.Text = "Off";
            // 
            // ConnPortCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 317);
            this.Controls.Add(this.lblOnOff);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnPortCOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion PortCOM";
            this.Load += new System.EventHandler(this.ConnPortCOM_Load);
            this.Resize += new System.EventHandler(this.ConnPortCOM_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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