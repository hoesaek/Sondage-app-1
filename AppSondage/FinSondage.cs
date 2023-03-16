using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSondage
{
    public partial class FinSondage : Form
    {
        public FinSondage()
        {
            InitializeComponent();
        }

        private void FinSondage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FinSondage_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Contactez le fournisseur au 04 77 36 38 10");
        }
    }
}
