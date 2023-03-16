namespace AppSondage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbVotantD = new TextBox();
            lblCode = new Label();
            pbR2 = new PictureBox();
            lblquestion = new Label();
            pbR1 = new PictureBox();
            label3 = new Label();
            tbVotantG = new TextBox();
            PanelLeft = new Panel();
            pictureBox1 = new PictureBox();
            lblInfo = new Label();
            pictureBox2 = new PictureBox();
            lblStat = new Label();
            pnlStat = new Panel();
            tbSondageTotal = new TextBox();
            label4 = new Label();
            tbNbVotantTotal = new TextBox();
            lblTotalCount = new Label();
            lblDate = new Label();
            pnlDateTime = new Panel();
            tbDateEnd = new TextBox();
            tbDateStart = new TextBox();
            lblDateEnd = new Label();
            lblDateStart = new Label();
            pnlBotG = new Panel();
            tbChoixG = new TextBox();
            lblChoixG = new Label();
            pnlinBotG = new Panel();
            tbNbVotantG = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pnlBotD = new Panel();
            tbChoixD = new TextBox();
            lblChoixD = new Label();
            pnlinBotD = new Panel();
            label2 = new Label();
            tbNbVotantD = new TextBox();
            pnlTop = new Panel();
            tbQuestion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbR2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbR1).BeginInit();
            PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlStat.SuspendLayout();
            pnlDateTime.SuspendLayout();
            pnlBotG.SuspendLayout();
            pnlinBotG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlBotD.SuspendLayout();
            pnlinBotD.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // tbVotantD
            // 
            tbVotantD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbVotantD.BackColor = Color.FromArgb(232, 228, 230);
            tbVotantD.BorderStyle = BorderStyle.FixedSingle;
            tbVotantD.ForeColor = Color.FromArgb(0, 70, 67);
            tbVotantD.Location = new Point(99, 24);
            tbVotantD.Name = "tbVotantD";
            tbVotantD.Size = new Size(217, 30);
            tbVotantD.TabIndex = 0;
            // 
            // lblCode
            // 
            lblCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCode.ForeColor = Color.FromArgb(0, 70, 67);
            lblCode.Location = new Point(3, 24);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(100, 29);
            lblCode.TabIndex = 9;
            lblCode.Text = "Votant :";
            // 
            // pbR2
            // 
            pbR2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbR2.BackgroundImageLayout = ImageLayout.Stretch;
            pbR2.Location = new Point(321, 21);
            pbR2.Margin = new Padding(2, 3, 2, 3);
            pbR2.Name = "pbR2";
            pbR2.Size = new Size(99, 86);
            pbR2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbR2.TabIndex = 4;
            pbR2.TabStop = false;
            pbR2.Click += pbR2_Click;
            // 
            // lblquestion
            // 
            lblquestion.AutoSize = true;
            lblquestion.BackColor = Color.Transparent;
            lblquestion.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblquestion.ForeColor = Color.FromArgb(171, 209, 198);
            lblquestion.Location = new Point(1, 24);
            lblquestion.Margin = new Padding(2, 0, 2, 0);
            lblquestion.Name = "lblquestion";
            lblquestion.Size = new Size(160, 36);
            lblquestion.TabIndex = 0;
            lblquestion.Text = "Question :";
            // 
            // pbR1
            // 
            pbR1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbR1.BackgroundImageLayout = ImageLayout.Stretch;
            pbR1.Location = new Point(333, 18);
            pbR1.Margin = new Padding(2, 3, 2, 3);
            pbR1.Name = "pbR1";
            pbR1.Size = new Size(83, 86);
            pbR1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbR1.TabIndex = 1;
            pbR1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 70, 67);
            label3.Location = new Point(0, 21);
            label3.Name = "label3";
            label3.Size = new Size(100, 29);
            label3.TabIndex = 11;
            label3.Text = "Votant :";
            // 
            // tbVotantG
            // 
            tbVotantG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbVotantG.BackColor = Color.FromArgb(232, 228, 230);
            tbVotantG.BorderStyle = BorderStyle.FixedSingle;
            tbVotantG.Enabled = false;
            tbVotantG.ForeColor = Color.FromArgb(0, 70, 67);
            tbVotantG.Location = new Point(92, 21);
            tbVotantG.Name = "tbVotantG";
            tbVotantG.Size = new Size(236, 30);
            tbVotantG.TabIndex = 12;
            // 
            // PanelLeft
            // 
            PanelLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PanelLeft.BackColor = Color.FromArgb(0, 70, 67);
            PanelLeft.Controls.Add(pictureBox1);
            PanelLeft.Controls.Add(lblInfo);
            PanelLeft.Controls.Add(pictureBox2);
            PanelLeft.Controls.Add(lblStat);
            PanelLeft.Controls.Add(pnlStat);
            PanelLeft.Controls.Add(lblDate);
            PanelLeft.Controls.Add(pnlDateTime);
            PanelLeft.ForeColor = Color.FromArgb(255, 110, 108);
            PanelLeft.Location = new Point(12, 12);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(317, 747);
            PanelLeft.TabIndex = 13;
            PanelLeft.Paint += pnlG_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(203, 668);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 66);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.FromArgb(171, 209, 198);
            lblInfo.Location = new Point(16, 29);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(284, 31);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "Information Sondage";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.BackgroundImage = Properties.Resources.logo_fmf_pnggd;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 668);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 66);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lblStat
            // 
            lblStat.AutoSize = true;
            lblStat.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblStat.ForeColor = Color.FromArgb(171, 209, 198);
            lblStat.Location = new Point(16, 313);
            lblStat.Name = "lblStat";
            lblStat.Size = new Size(298, 29);
            lblStat.TabIndex = 4;
            lblStat.Text = "Statistique du Sondage :";
            // 
            // pnlStat
            // 
            pnlStat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlStat.BackColor = Color.FromArgb(249, 188, 96);
            pnlStat.BackgroundImageLayout = ImageLayout.Stretch;
            pnlStat.Controls.Add(tbSondageTotal);
            pnlStat.Controls.Add(label4);
            pnlStat.Controls.Add(tbNbVotantTotal);
            pnlStat.Controls.Add(lblTotalCount);
            pnlStat.ForeColor = Color.Transparent;
            pnlStat.Location = new Point(12, 357);
            pnlStat.Name = "pnlStat";
            pnlStat.Size = new Size(297, 132);
            pnlStat.TabIndex = 9;
            // 
            // tbSondageTotal
            // 
            tbSondageTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbSondageTotal.BackColor = Color.FromArgb(232, 228, 230);
            tbSondageTotal.BorderStyle = BorderStyle.FixedSingle;
            tbSondageTotal.Enabled = false;
            tbSondageTotal.ForeColor = Color.FromArgb(0, 70, 67);
            tbSondageTotal.Location = new Point(191, 87);
            tbSondageTotal.Name = "tbSondageTotal";
            tbSondageTotal.Size = new Size(85, 30);
            tbSondageTotal.TabIndex = 6;
            tbSondageTotal.Text = "0";
            tbSondageTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 70, 67);
            label4.Location = new Point(4, 59);
            label4.Name = "label4";
            label4.Size = new Size(165, 58);
            label4.TabIndex = 5;
            label4.Text = "Nombre total\r\nde sondage :";
            // 
            // tbNbVotantTotal
            // 
            tbNbVotantTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNbVotantTotal.BackColor = Color.FromArgb(232, 228, 230);
            tbNbVotantTotal.BorderStyle = BorderStyle.FixedSingle;
            tbNbVotantTotal.Enabled = false;
            tbNbVotantTotal.ForeColor = Color.FromArgb(0, 70, 67);
            tbNbVotantTotal.Location = new Point(191, 20);
            tbNbVotantTotal.Name = "tbNbVotantTotal";
            tbNbVotantTotal.Size = new Size(85, 30);
            tbNbVotantTotal.TabIndex = 4;
            tbNbVotantTotal.Text = "0";
            tbNbVotantTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalCount.AutoSize = true;
            lblTotalCount.BackColor = Color.Transparent;
            lblTotalCount.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCount.ForeColor = Color.FromArgb(0, 70, 67);
            lblTotalCount.Location = new Point(4, 21);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(157, 29);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "Votant total :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.FromArgb(171, 209, 198);
            lblDate.Location = new Point(12, 85);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(249, 29);
            lblDate.TabIndex = 2;
            lblDate.Text = "Durée du  sondage :";
            // 
            // pnlDateTime
            // 
            pnlDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDateTime.BackColor = Color.FromArgb(249, 188, 96);
            pnlDateTime.BackgroundImageLayout = ImageLayout.Stretch;
            pnlDateTime.Controls.Add(tbDateEnd);
            pnlDateTime.Controls.Add(tbDateStart);
            pnlDateTime.Controls.Add(lblDateEnd);
            pnlDateTime.Controls.Add(lblDateStart);
            pnlDateTime.ForeColor = Color.Transparent;
            pnlDateTime.Location = new Point(12, 117);
            pnlDateTime.Name = "pnlDateTime";
            pnlDateTime.Size = new Size(297, 162);
            pnlDateTime.TabIndex = 10;
            // 
            // tbDateEnd
            // 
            tbDateEnd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDateEnd.BackColor = Color.FromArgb(232, 228, 230);
            tbDateEnd.BorderStyle = BorderStyle.FixedSingle;
            tbDateEnd.Enabled = false;
            tbDateEnd.ForeColor = Color.FromArgb(0, 70, 67);
            tbDateEnd.Location = new Point(20, 120);
            tbDateEnd.Name = "tbDateEnd";
            tbDateEnd.Size = new Size(226, 30);
            tbDateEnd.TabIndex = 3;
            tbDateEnd.Text = "00/00/00";
            tbDateEnd.TextAlign = HorizontalAlignment.Center;
            // 
            // tbDateStart
            // 
            tbDateStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDateStart.BackColor = Color.FromArgb(232, 228, 230);
            tbDateStart.BorderStyle = BorderStyle.FixedSingle;
            tbDateStart.Enabled = false;
            tbDateStart.ForeColor = Color.FromArgb(0, 70, 67);
            tbDateStart.Location = new Point(20, 43);
            tbDateStart.Name = "tbDateStart";
            tbDateStart.Size = new Size(226, 30);
            tbDateStart.TabIndex = 2;
            tbDateStart.Text = "00/00/00";
            tbDateStart.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDateEnd
            // 
            lblDateEnd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDateEnd.AutoSize = true;
            lblDateEnd.BackColor = Color.Transparent;
            lblDateEnd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateEnd.ForeColor = Color.FromArgb(0, 70, 67);
            lblDateEnd.Location = new Point(20, 88);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(162, 29);
            lblDateEnd.TabIndex = 1;
            lblDateEnd.Text = "Date de Fin :";
            // 
            // lblDateStart
            // 
            lblDateStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDateStart.AutoSize = true;
            lblDateStart.BackColor = Color.Transparent;
            lblDateStart.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateStart.ForeColor = Color.FromArgb(0, 70, 67);
            lblDateStart.Location = new Point(20, 11);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(191, 29);
            lblDateStart.TabIndex = 0;
            lblDateStart.Text = "Date de début :";
            // 
            // pnlBotG
            // 
            pnlBotG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBotG.BackColor = Color.FromArgb(0, 70, 67);
            pnlBotG.Controls.Add(tbChoixG);
            pnlBotG.Controls.Add(lblChoixG);
            pnlBotG.Controls.Add(pnlinBotG);
            pnlBotG.Location = new Point(332, 500);
            pnlBotG.Name = "pnlBotG";
            pnlBotG.Size = new Size(495, 259);
            pnlBotG.TabIndex = 14;
            // 
            // tbChoixG
            // 
            tbChoixG.BackColor = Color.FromArgb(232, 228, 230);
            tbChoixG.BorderStyle = BorderStyle.FixedSingle;
            tbChoixG.Enabled = false;
            tbChoixG.ForeColor = Color.FromArgb(0, 70, 67);
            tbChoixG.Location = new Point(140, 20);
            tbChoixG.Name = "tbChoixG";
            tbChoixG.Size = new Size(214, 30);
            tbChoixG.TabIndex = 10;
            tbChoixG.TextAlign = HorizontalAlignment.Center;
            // 
            // lblChoixG
            // 
            lblChoixG.AutoSize = true;
            lblChoixG.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblChoixG.ForeColor = Color.FromArgb(171, 209, 198);
            lblChoixG.Location = new Point(19, 22);
            lblChoixG.Name = "lblChoixG";
            lblChoixG.Size = new Size(132, 29);
            lblChoixG.TabIndex = 9;
            lblChoixG.Text = "Réponse :";
            // 
            // pnlinBotG
            // 
            pnlinBotG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlinBotG.BackColor = Color.FromArgb(249, 188, 96);
            pnlinBotG.Controls.Add(tbNbVotantG);
            pnlinBotG.Controls.Add(tbVotantG);
            pnlinBotG.Controls.Add(label1);
            pnlinBotG.Controls.Add(pbR1);
            pnlinBotG.Controls.Add(label3);
            pnlinBotG.Location = new Point(15, 73);
            pnlinBotG.Name = "pnlinBotG";
            pnlinBotG.Size = new Size(450, 126);
            pnlinBotG.TabIndex = 8;
            // 
            // tbNbVotantG
            // 
            tbNbVotantG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNbVotantG.BackColor = Color.FromArgb(232, 228, 230);
            tbNbVotantG.BorderStyle = BorderStyle.FixedSingle;
            tbNbVotantG.Enabled = false;
            tbNbVotantG.ForeColor = Color.FromArgb(0, 70, 67);
            tbNbVotantG.Location = new Point(261, 74);
            tbNbVotantG.Name = "tbNbVotantG";
            tbNbVotantG.Size = new Size(54, 30);
            tbNbVotantG.TabIndex = 11;
            tbNbVotantG.Text = "0";
            tbNbVotantG.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 70, 67);
            label1.Location = new Point(4, 75);
            label1.Name = "label1";
            label1.Size = new Size(251, 29);
            label1.TabIndex = 5;
            label1.Text = "Nombre de Votants :";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackgroundImage = Properties.Resources.MachineAvoterLogo;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(754, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(119, 135);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pnlBotD
            // 
            pnlBotD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlBotD.BackColor = Color.FromArgb(0, 70, 67);
            pnlBotD.Controls.Add(tbChoixD);
            pnlBotD.Controls.Add(lblChoixD);
            pnlBotD.Controls.Add(pnlinBotD);
            pnlBotD.Location = new Point(833, 500);
            pnlBotD.Name = "pnlBotD";
            pnlBotD.Size = new Size(485, 259);
            pnlBotD.TabIndex = 15;
            // 
            // tbChoixD
            // 
            tbChoixD.BackColor = Color.FromArgb(232, 228, 230);
            tbChoixD.BorderStyle = BorderStyle.FixedSingle;
            tbChoixD.Enabled = false;
            tbChoixD.ForeColor = Color.FromArgb(0, 70, 67);
            tbChoixD.Location = new Point(140, 20);
            tbChoixD.Name = "tbChoixD";
            tbChoixD.Size = new Size(217, 30);
            tbChoixD.TabIndex = 12;
            tbChoixD.TextAlign = HorizontalAlignment.Center;
            tbChoixD.TextChanged += tbChoixD_TextChanged;
            // 
            // lblChoixD
            // 
            lblChoixD.AutoSize = true;
            lblChoixD.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblChoixD.ForeColor = Color.FromArgb(171, 209, 198);
            lblChoixD.Location = new Point(19, 22);
            lblChoixD.Name = "lblChoixD";
            lblChoixD.Size = new Size(132, 29);
            lblChoixD.TabIndex = 11;
            lblChoixD.Text = "Réponse :";
            // 
            // pnlinBotD
            // 
            pnlinBotD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlinBotD.BackColor = Color.FromArgb(249, 188, 96);
            pnlinBotD.Controls.Add(label2);
            pnlinBotD.Controls.Add(tbNbVotantD);
            pnlinBotD.Controls.Add(pbR2);
            pnlinBotD.Controls.Add(tbVotantD);
            pnlinBotD.Controls.Add(lblCode);
            pnlinBotD.Location = new Point(19, 73);
            pnlinBotD.Name = "pnlinBotD";
            pnlinBotD.Size = new Size(451, 126);
            pnlinBotD.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 70, 67);
            label2.Location = new Point(0, 75);
            label2.Name = "label2";
            label2.Size = new Size(251, 29);
            label2.TabIndex = 10;
            label2.Text = "Nombre de Votants :";
            // 
            // tbNbVotantD
            // 
            tbNbVotantD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNbVotantD.BackColor = Color.FromArgb(232, 228, 230);
            tbNbVotantD.BorderStyle = BorderStyle.FixedSingle;
            tbNbVotantD.Enabled = false;
            tbNbVotantD.ForeColor = Color.FromArgb(0, 70, 67);
            tbNbVotantD.Location = new Point(251, 74);
            tbNbVotantD.Name = "tbNbVotantD";
            tbNbVotantD.Size = new Size(65, 30);
            tbNbVotantD.TabIndex = 6;
            tbNbVotantD.Text = "0";
            tbNbVotantD.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = Color.FromArgb(0, 70, 67);
            pnlTop.Controls.Add(tbQuestion);
            pnlTop.Controls.Add(lblquestion);
            pnlTop.Location = new Point(331, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(987, 84);
            pnlTop.TabIndex = 16;
            pnlTop.Paint += pnlTop_Paint;
            // 
            // tbQuestion
            // 
            tbQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbQuestion.BackColor = Color.FromArgb(232, 228, 230);
            tbQuestion.BorderStyle = BorderStyle.FixedSingle;
            tbQuestion.Enabled = false;
            tbQuestion.Font = new Font("Bahnschrift SemiLight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuestion.ForeColor = Color.FromArgb(0, 70, 67);
            tbQuestion.Location = new Point(143, 17);
            tbQuestion.Multiline = true;
            tbQuestion.Name = "tbQuestion";
            tbQuestion.Size = new Size(829, 43);
            tbQuestion.TabIndex = 1;
            tbQuestion.TextAlign = HorizontalAlignment.Center;
            tbQuestion.TextChanged += tbQuestion_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(171, 209, 198);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1330, 761);
            Controls.Add(pnlTop);
            Controls.Add(pnlBotD);
            Controls.Add(pnlBotG);
            Controls.Add(PanelLeft);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sondage";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pbR2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbR1).EndInit();
            PanelLeft.ResumeLayout(false);
            PanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlStat.ResumeLayout(false);
            pnlStat.PerformLayout();
            pnlDateTime.ResumeLayout(false);
            pnlDateTime.PerformLayout();
            pnlBotG.ResumeLayout(false);
            pnlBotG.PerformLayout();
            pnlinBotG.ResumeLayout(false);
            pnlinBotG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlBotD.ResumeLayout(false);
            pnlBotD.PerformLayout();
            pnlinBotD.ResumeLayout(false);
            pnlinBotD.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbR2;
        private Label lblquestion;
        private TextBox tbVotantD;
        private Label lblCode;
        private PictureBox pbR1;
        private Label label3;
        private TextBox tbVotantG;
        private Panel PanelLeft;
        public EllipseControl ellipsePanelLeft;
        private Label lblDate;
        private Panel pnlDateTime;
        private TextBox tbDateEnd;
        private TextBox tbDateStart;
        private Label lblDateEnd;
        private Label lblDateStart;
        private Label lblStat;
        private Panel pnlStat;
        private PictureBox pictureBox2;
        private Panel pnlBotG;
        private EllipseControl ellipsePnlBotG;
        private Panel pnlBotD;
        private EllipseControl ellipsePnlBotD;
        private Label lblInfo;
        private Panel pnlTop;
        private EllipseControl ellipseTop;
        private Label lblTotalCount;
        private Panel pnlinBotG;
        private Panel pnlinBotD;
        private TextBox tbQuestion;
        private PictureBox pictureBox1;
        private TextBox tbNbVotantTotal;
        private PictureBox pictureBox3;
        private TextBox tbChoixG;
        private Label lblChoixG;
        private TextBox tbChoixD;
        private Label lblChoixD;
        private TextBox tbNbVotantG;
        private Label label1;
        private Label label2;
        private TextBox tbNbVotantD;
        private TextBox tbSondageTotal;
        private Label label4;
    }
}