using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Windows.ApplicationModel.VoiceCommands;
using Windows.Networking.NetworkOperators;
using Windows.UI.Popups;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AppSondage
{
    public partial class Form1 : Form
    {
        FinSondage? infoSodage;
        public Form1()
        {
            InitializeComponent();
            Connect();
            ReadFirst();
        }
        public void UpdateLabel(string dataIn)
        {
            tbVotantG.Text = dataIn;
        }
        public void SetTextBoxZero()
        {
            tbVotantG.Text = "";
            tbVotantD.Text = "";
        }
        private MySqlConnection Connect()
        {
            MySqlConnection connection = GetDBConnection();
            try
            {
                connection.Open();
            }
            catch (Exception err) { MessageBox.Show(err.Message, "Impossible de se connecter à la base de donnees", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error); }
            return connection;
        }
        private MySqlConnection ClostConnect()
        {
            MySqlConnection connection = Connect();
            try
            {
                connection.Close();
            }
            catch (Exception err) { MessageBox.Show(err.Message, "Impossible de fermer la base de donnees", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error); }
            return connection;
        }
        public void UpdateDB(string dataIn)
        {
            Read(dataIn);
            Count();
        }
        private void ReadFirst()
        {
            DateTime dateFin;
            DateTime dateDebut;

            //table sondage
            string selectSondage = "SELECT idsondages,question,option1,option2,dateDebut,dateFin FROM sondages";
            string selectVotant = "SELECT codePassRegion FROM votants";

            string selectSondage_has_votants = "SELECT idsondages,idvotants from sondages_has_votants";

            MySqlCommand cmdSondages = new MySqlCommand(selectSondage);
            MySqlCommand select_SHasVotant = new MySqlCommand(selectSondage_has_votants);
            MySqlCommand select_Votant = new MySqlCommand(selectVotant);
            try
            {
                cmdSondages.Connection = Connect();
                select_SHasVotant.Connection = Connect();
                select_Votant.Connection = Connect();
                //select des differents elements de la base de donnees
                using DbDataReader reader = cmdSondages.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        infoSodage = new FinSondage();
                        // La colonne question a l'indexe = 1.
                        string question = reader.GetString(1);
                        tbQuestion.Text = question;
                        string option1 = reader.GetString(2);
                        tbChoixG.Text = option1;
                        string option2 = reader.GetString(3);
                        tbChoixD.Text = option2;
                        dateDebut = reader.GetDateTime(4);
                        tbDateStart.Text = dateDebut.ToString();
                        if (dateDebut == DateTime.Now) { this.Show(); infoSodage.Hide(); }
                        dateFin = reader.GetDateTime(5);
                        tbDateEnd.Text = dateFin.ToString();
                        if (dateFin == DateTime.Now) { this.Hide(); infoSodage.Show(); }
                    }
                }
                reader.Close();
            }
            catch (Exception error) { MessageBox.Show(error.Message, "Probleme de lecture dans la base de données", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error); }
        } //premiere lecture de la base de donnees
        private void Read(string dataIn)
        {
            DateTime dateFin;
            DateTime dateDebut;

            //table sondage
            string selectSondage = "SELECT idsondages,question,option1,option2,dateDebut,dateFin FROM sondages";
            string selectVotant = "SELECT codePassRegion FROM votants";

            string selectSondage_has_votants = "SELECT idsondages,idvotants from sondages_has_votants";

            MySqlCommand cmdSondages = new MySqlCommand(selectSondage);
            MySqlCommand select_SHasVotant = new MySqlCommand(selectSondage_has_votants);
            MySqlCommand select_Votant = new MySqlCommand(selectVotant);
            try
            {
                cmdSondages.Connection = Connect();
                select_SHasVotant.Connection = Connect();
                select_Votant.Connection = Connect();
                //select des differents elements de la base de donnees
                using DbDataReader reader = cmdSondages.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        infoSodage = new FinSondage();
                        // La colonne question a l'indexe = 1.
                        string question = reader.GetString(1);
                        tbQuestion.Text = question;
                        string option1 = reader.GetString(2);
                        tbChoixG.Text = option1;
                        string option2 = reader.GetString(3);
                        tbChoixD.Text = option2;
                        dateDebut = reader.GetDateTime(4);
                        tbDateStart.Text = dateDebut.ToString();
                        if (dateDebut == DateTime.Now) { this.Show(); infoSodage.Hide(); }
                        dateFin = reader.GetDateTime(5);
                        tbDateEnd.Text = dateFin.ToString();
                        if (dateFin == DateTime.Now) { this.Hide(); infoSodage.Show(); }
                    }
                }
                reader.Close();
                using DbDataReader readerVote = select_Votant.ExecuteReader();
                if (readerVote.HasRows)
                {
                    while (readerVote.Read())
                    {
                        if (readerVote.ToString() == dataIn)
                        {
                            AutoClosingMessageBox.Show(dataIn, ": vous avez déjà voté revenez lors d'un prochain sondage.", 5000);
                        }
                        else { Insert(); }
                    }
                }
                readerVote.Close();
            }
            catch (Exception error) { MessageBox.Show(error.Message, "Probleme de lecture dans la base de données", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error); }
        }
        private void Insert()
        {

            //table votant
            string insertVotant = "INSERT INTO votants (codePassRegion) VALUES (@codePassRegion)";
            //table sondage_has_votant
            string insertSondage_has_votants = "INSERT INTO sondages_has_votants (optionChoisie) VALUES (@optionChoisie)";
            //faire un select de datain pour verifier si la valeur est deja dans la base de donnees

            MySqlCommand ins_cmdVotants = new MySqlCommand(insertVotant);
            MySqlCommand ins_SHasVotant = new MySqlCommand(insertSondage_has_votants);

            try
            {
                ins_cmdVotants.Connection = Connect();
                ins_SHasVotant.Connection = Connect();

                if (tbVotantD.Text == "") { ins_cmdVotants.Parameters.AddWithValue("@codePassRegion", tbVotantG.Text); ins_SHasVotant.Parameters.AddWithValue("@optionChoisie", "Option : 1"); SetTextBoxZero(); }
                else { ins_cmdVotants.Parameters.AddWithValue("@codePassRegion", tbVotantD.Text); ins_SHasVotant.Parameters.AddWithValue("@optionChoisie", "Option : 2"); SetTextBoxZero(); }

            }
            catch (Exception error) { MessageBox.Show(error.Message, "Probleme d'insertion des elements dans la base de donnees", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
        }
        private void Count()
        {
            string coutVotant = "SELECT COUNT(DISTINCT idvotants) FROM votants";
            string option1 = "SELECT COUNT(DISTINCT optionChoisie) FROM sondages_has_votants WHERE optionChoisie = Option : 1";
            string option2 = "SELECT COUNT(DISTINCT optionChoisie) FROM sondages_has_votants WHERE optionChoisie = Option : 2";
            string coutSondage = "SELECT COUNT(DISTINCT sondages_idsondages) FROM sondages_has_votants";
            MySqlCommand count_cmdVotants = new MySqlCommand(coutVotant);
            MySqlCommand count_Sondage = new MySqlCommand(coutSondage);
            MySqlCommand count_option1 = new MySqlCommand(option1);
            MySqlCommand count_option2 = new MySqlCommand(option2);

            try
            {
                // établissement de la connexion de la commande.
                count_cmdVotants.Connection = Connect();
                count_Sondage.Connection = Connect();
                count_option1.Connection = Connect();
                count_option2.Connection = Connect();
                // compte pour nb votant
                Int64 countvotant = (Int64)count_cmdVotants.ExecuteScalar();
                if (countvotant <= 0) { tbNbVotantTotal.Text = "0"; } else { tbNbVotantTotal.Text = countvotant.ToString(); }
                //nb total de sondage enregistrer dans la bdd
                Int64 countsondage = (Int64)count_Sondage.ExecuteScalar();
                if (countsondage <= 0) { tbSondageTotal.Text = "0"; } else { tbSondageTotal.Text = countsondage.ToString(); }
                //compte pour nombre de votant avec option 1 et 2
                //option1
                Int64 countoption1 = (Int64)count_option1.ExecuteScalar();
                if (countoption1 <= 0) { tbNbVotantG.Text = "0"; } else { tbNbVotantG.Text = countoption1.ToString(); }
                //option2
                Int64 countoption2 = (Int64)count_option2.ExecuteScalar();
                if (countoption2 <= 0) { tbNbVotantD.Text = "0"; } else { tbNbVotantD.Text = countoption2.ToString(); }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Probleme de comptage des elements de la base de donnees", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public static MySqlConnection GetDBConnection()
        {
            BDD db = new BDD();
            string host = /*"127.0.0.1";*/ "172.18.199.9";
            int port = 3306;
            string database = /*"mydb";*/ "bddsondages";
            string username = "root";
            string password = /*"";*/ "%STS*Mauriacdb";

            return db.GetDBConnection(host, port, database, username, password);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbVotantD.Focus();
            if (!tbVotantD.Focused || tbVotantD.Text == "")
            {
                tbVotantD.Focus();
            }

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            this.ClostConnect();
        }
        private void pnlG_Paint(object sender, PaintEventArgs e) { }
        private void pbR2_Click(object sender, EventArgs e)
        {

        }
        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void tbChoixD_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            tbVotantD.Focus();
            if (!tbVotantD.Focused || tbVotantD.Text == "")
            {
                tbVotantD.Focus();
            }
        }
        private void pnlinBotD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlinBotG_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}