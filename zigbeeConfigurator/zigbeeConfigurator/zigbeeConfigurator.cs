using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace zigbeeConfigurator
{
    public partial class Form1 : Form
    {
        string receiveFromSerial;
        private bool listenMode=true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String portname in System.IO.Ports.SerialPort.GetPortNames()) cmbPorts.Items.Add(portname);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Tag.ToString() == "0")
            {
                try
                {
                    if (cmbPorts.SelectedItem == null) MessageBox.Show("Choisissez un port !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        serialPort1.PortName = cmbPorts.SelectedItem.ToString();
                        serialPort1.Open();
                        //btnConnect.Enabled = false;
                        grbConfigurer.Enabled = true;
                        grbTransmettre.Enabled = true;
                        btnConnect.Text = "Déconnexion";
                        btnConnect.Tag = 1;
                    }
                }
                catch
                {
                    MessageBox.Show("Impossible d'ouvrir le port " + serialPort1.PortName, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                serialPort1.Close();
                txbTerm.Clear();
                txbDeviceName.Clear();
                btnConnect.Text = "Connexion";
                btnConnect.Tag = 0;
                grbConfigurer.Enabled = false;
                grbTransmettre.Enabled = false;
                listenMode = true;
            }
        }

        private void btnConfigurer_Click(object sender, EventArgs e)
        {
            if (txtPANID.Text == "") MessageBox.Show("Configurez le PAN ID ", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                listenMode = false;
                serialPort1.Write("+++");
                if ((receiveFromSerial = serialPort1.ReadTo("\r")) != "OK")
                {
                    MessageBox.Show("Impossible d'entrer en mode COMMAND", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txbTerm.AppendText("+++\r\n" + receiveFromSerial + "\n");

                    serialPort1.Write("ATID" + txtPANID.Text + "\r");
                    if ((receiveFromSerial = serialPort1.ReadTo("\r")) != "OK")
                    {
                        MessageBox.Show("Impossible de configurer PAN ID", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else txbTerm.AppendText("ATID" + txtPANID.Text + "\r\n" + receiveFromSerial + "\n");
                    if (rdbCoordinator.Checked)
                    {
                        serialPort1.Write("ATJV0\r");
                        if ((receiveFromSerial = serialPort1.ReadTo("\r")) != "OK")
                        {
                            MessageBox.Show("Impossible de configurer JV0", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else txbTerm.AppendText("ATJV0\r\n" + receiveFromSerial + "\n");

                        serialPort1.Write("ATDLFFFF\r");
                        if ((receiveFromSerial = serialPort1.ReadTo("\r")) != "OK")
                        {
                            MessageBox.Show("Impossible de configurer le mode Broadcast", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else txbTerm.AppendText("ATDLFFFF\r\n" + receiveFromSerial + "\n");

                        //Thread.Sleep(2000);
                        serialPort1.Write("ATCE1\r");
                        if ((receiveFromSerial = serialPort1.ReadTo("\r")) != "OK")
                        {
                            MessageBox.Show("Impossible de configurer CE1", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else txbTerm.AppendText("ATCE1\r\n" + receiveFromSerial + "\n");
                        //Thread.Sleep(1000);
                    }
                    if (rdbRouter.Checked)
                    {
                        serialPort1.Write("ATJV1\r");
                        if ((receiveFromSerial = serialPort1.ReadTo("\r")) != "OK")
                        {
                            MessageBox.Show("Impossible de configurer JV1", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else txbTerm.AppendText("ATJV1\r\n" + receiveFromSerial + "\n");

                        serialPort1.Write("ATCE0\r");
                        if ((receiveFromSerial = serialPort1.ReadTo("\r")) != "OK")
                        {
                            MessageBox.Show("Impossible de configurer CE0", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else txbTerm.AppendText("ATCE0\r\n" + receiveFromSerial + "\n");
                    }
                    if (txbDeviceName.Text != "")
                    {
                        serialPort1.Write("ATNI" + txbDeviceName.Text + "\r");
                        if ((receiveFromSerial = serialPort1.ReadTo("\r")) != "OK")
                        {
                            MessageBox.Show("Impossible de configurer le nom du device", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else txbTerm.AppendText("ATNI" + txbDeviceName.Text + "\r\n" + receiveFromSerial + "\n");
                    }
                }

                serialPort1.Write("ATWR\r");
                if ((receiveFromSerial = serialPort1.ReadTo("\r")) == "OK")
                {
                    MessageBox.Show("Configuration enregistrée !", "Message !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Impossible d'enregitrer la configuration", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                serialPort1.Write("ATAC\r");
                Thread.Sleep(1000);
                serialPort1.Write("ATCN\r");
                if ((receiveFromSerial = serialPort1.ReadTo("\r")) == "OK")
                {
                    MessageBox.Show("Fin du mode COMMAND", "Message !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbTerm.Clear();
                    listenMode = true;
                    receiveFromSerial = null;
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (listenMode)
            {
                receiveFromSerial = serialPort1.ReadExisting();
                Invoke(new EventHandler(updateTerm));
            }
        }

        private void updateTerm(object sender, EventArgs e)
        {
            txbTerm.AppendText(receiveFromSerial);
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if (txbToSend.Text != "") serialPort1.Write(txbToSend.Text);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            serialPort1.Write("\r\n");
        }

        private void btnLireConfig_Click(object sender, EventArgs e)
        {
            listenMode = false;
            string JV,CE,ID,NI;
            serialPort1.Write("+++");
            
            if ((receiveFromSerial = serialPort1.ReadTo("\r")) != "OK")
            {
                MessageBox.Show("Impossible d'entrer en mode COMMAND", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                serialPort1.Write("ATID\r");
                
                try
                {
                    if ((ID = serialPort1.ReadTo("\r")) == null)
                    {
                        MessageBox.Show("Impossible de lire PAN ID", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(ID!="OK") txtPANID.Text = ID;
                        else if ((ID = serialPort1.ReadTo("\r")) == null)
                             {
                                MessageBox.Show("Impossible de lire PAN ID", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                             else txtPANID.Text = ID;
                    }
                }
                catch
                {

                }

                serialPort1.Write("ATJV\r");
                try
                {
                    if ((JV = serialPort1.ReadTo("\r")) == null)
                    {
                        MessageBox.Show("Impossible de lire JV", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        serialPort1.Write("ATCE\r");

                        if ((CE = serialPort1.ReadTo("\r")) == null)
                        {
                            MessageBox.Show("Impossible de configurer CE", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (CE == "0" && JV == "1") rdbRouter.Checked = true;
                            if (CE == "1" && JV == "0") rdbCoordinator.Checked = true;
                        }
                    }
                }
                catch { }

                serialPort1.Write("ATNI\r");
                try
                {

                    if ((NI = serialPort1.ReadTo("\r")) == null)
                    {
                        MessageBox.Show("Impossible de lire le nom du module", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txbDeviceName.Text = NI;
                    }
                }
                catch { }
            }
        }

    }
}
