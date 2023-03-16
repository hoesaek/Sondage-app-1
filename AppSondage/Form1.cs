using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace AppSondage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //FinSondage finSondage = new FinSondage();
            this.Connect();

        }
        public void updateLabel(string s)
        {
            tbVotantG.Text = s;
        }

        public void setTextBoxZero()
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
            catch (Exception err) { MessageBox.Show(err.Message, "", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error); }
            return connection;
        }

        private void SqlCommand()
        {
            

        }

        public void updateDB()
        {

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
            this.Close();
        }
        private void pnlG_Paint(object sender, PaintEventArgs e)
        { }
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
    }
}