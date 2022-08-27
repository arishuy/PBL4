using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PBL4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            String myping = textBox1.Text;
            Ping p1 = new Ping();
            PingReply PR = p1.Send(myping);
            label2.Text = PR.Status.ToString();
            p1.Dispose();
        }
    }
}
