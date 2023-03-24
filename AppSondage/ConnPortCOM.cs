using System;
using System.IO.Ports;

namespace AppSondage
{
    public partial class ConnPortCOM : Form
    {
        string dataIn;
        string adminkey = "0x7265626F6F741B4442";
        Form1 sondage;
        FinSondage FinSondage;
        SerialPort serialPort = new SerialPort();
        public ConnPortCOM()
        {
            InitializeComponent();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            if (cbBR.Items.Contains(110)) serialPort.BaudRate = 110;
            else if (cbBR.Items.Contains(300)) serialPort.BaudRate = 300;
            else if (cbBR.Items.Contains(600)) serialPort.BaudRate = 600;
            else if (cbBR.Items.Contains(1200)) serialPort.BaudRate = 1200;
            else if (cbBR.Items.Contains(2400)) serialPort.BaudRate = 2400;
            else if (cbBR.Items.Contains(4800)) serialPort.BaudRate = 4800;
            else if (cbBR.Items.Contains(14400)) serialPort.BaudRate = 14400;
            else if (cbBR.Items.Contains(19200)) serialPort.BaudRate = 19200;
            else if (cbBR.Items.Contains(38400)) serialPort.BaudRate = 38400;

            if (cbDB.Items.Contains(6)) serialPort.DataBits = 6;
            else serialPort.DataBits = 7;

            if (cbSB.Items.Contains("Two")) serialPort.StopBits = StopBits.Two;

            if (cbPB.Items.Contains("Odd")) serialPort.Parity = Parity.Odd;
            else serialPort.Parity = Parity.Even;
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialPort = (SerialPort)sender;
            while (dataIn == serialPort.ReadExisting())
            {
                if (dataIn == adminkey)
                {
                    sondage.UpdateDB(dataIn);
                    sondage.SetTextBoxZero();
                }
                else
                {
                    sondage.UpdateDB(dataIn);
                    sondage.UpdateLabel(dataIn);
                }
            }
        }


        private void ConnPortCOM_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            foreach (string portName in port)
            {
                cbCOM.Items.Add(portName);
            }

            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;
        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            sondage = new Form1();
            sondage.Show();
            this.Hide();
        }

        private void cbBR_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = cbCOM.Text;
                serialPort.BaudRate = Convert.ToInt32(cbBR.Text);
                serialPort.DataBits = Convert.ToInt32(cbDB.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbSB.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbPB.Text);
                serialPort.ReadTimeout = 500;

                serialPort.Open();
                lblOnOff.Text = "On";
                progressBar1.Value = 100;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erreur de parametrage du port serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblOnOff.Text = "Off";
                progressBar1.Value = 0;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    progressBar1.Value = 0;
                    cbCOM.Items.Clear();
                    cbBR.Items.Clear();
                    cbDB.Items.Clear();
                    cbSB.Items.Clear();
                    cbPB.Items.Clear();
                }
            }
            catch (Exception err) { MessageBox.Show(err.Message, "Error"); }
            Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            lblOnOff.Text = "Off";
            progressBar1.Value = 0;
        }

        private void ConnPortCOM_Resize(object sender, EventArgs e)
        {

        }
    }
}