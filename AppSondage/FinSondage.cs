using System.ComponentModel;

namespace AppSondage
{
    public partial class FinSondage : Form
    {
        public FinSondage()
        {
            InitializeComponent();
        }

        private void FinSondage_Load(object sender, EventArgs e)
        { }

        private void FinSondage_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Contactez le fournisseur au 04 77 36 38 10");
        }
    }
}
