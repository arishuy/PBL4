using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL4
{
    public partial class PingTool : Form
    {
        public PingTool()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            String myping = textBox1.Text;
            if (!IPAddress.TryParse(myping, out IPAddress address))
                MessageBox.Show("Please enter a valid IP address");
            else
            {
                Ping p1 = new Ping();
                PingReply PR = p1.Send(address);
                if (PR.Status == IPStatus.Success)
                {
                    label6.Text = PR.RoundtripTime.ToString() + " ms";
                    label3.ForeColor = Color.Lime;
                    label3.Text = "Ping to " + myping + " was successful";
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label6.Text = "";
                    label3.Text = "Ping to " + myping + " was unsuccessful";
                }
                p1.Dispose();
            }
        }
    }
}
