using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Close Window and terminate application
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        // Start a new RDP-Session with the entered computer name
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (tbComputerName.Text != "")
            {

                if (tbComputerName.Text.All(x => char.IsLetterOrDigit(x) || char.IsPunctuation(x))) {

                    Process newRDPConnection = new Process();
                    newRDPConnection.StartInfo.FileName = "mstsc.exe";
                    newRDPConnection.StartInfo.Arguments = "/remoteguard /v:" + tbComputerName.Text;
                    newRDPConnection.Start();
                    this.Close();

                }
                else {

                    MessageBox.Show(this, "The computer name is not valid.", "Secure Remote Desktop Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else {

                MessageBox.Show(this, "Please enter a computer name.", "Secure Remote Desktop Connection",  MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        // Start a new RDP-Session with the entered computer name
        private void tbComputerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (tbComputerName.Text != "")
                {

                    if (tbComputerName.Text.All(x => char.IsLetterOrDigit(x) || char.IsPunctuation(x)))
                    {

                        Process newRDPConnection = new Process();
                        newRDPConnection.StartInfo.FileName = "mstsc.exe";
                        newRDPConnection.StartInfo.Arguments = "/remoteguard /v:" + tbComputerName.Text;
                        newRDPConnection.Start();
                        this.Close();

                    }
                    else
                    {

                        MessageBox.Show(this, "The computer name is not valid.", "Secure Remote Desktop Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {

                    MessageBox.Show(this, "Please enter a computer name.", "Secure Remote Desktop Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
