using System;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PBL4
{
    public partial class Form1 : Form
    {
        DataTable data;
        public Form1()
        {
            InitializeComponent();
            data = new DataTable();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data.Columns.AddRange(new DataColumn[] { new DataColumn("IP"),
                new DataColumn("Host Name"),
                new DataColumn("Status"),
            });
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            String myping = textBox1.Text;
            if (!IPAddress.TryParse(myping, out IPAddress address))
                MessageBox.Show("Please enter a valid IP address");
            else
            {
                Ping p1 = new Ping();
                PingReply PR = p1.Send(address);
                if (PR.Status == IPStatus.Success)
                {
                    label2.ForeColor = Color.Green;
                    label2.Text = "Ping to " + myping + " was successful";
                }
                else
                {
                label2.ForeColor = Color.Red;

                    label2.Text = "Ping to " + myping + " was unsuccessful";
                }
                p1.Dispose();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            data.Rows.Clear();
                lbStatus.ForeColor = Color.Blue;
                lbStatus.Text = "Scanning...";
                progressBar.Value = 0;
                progressBar.Maximum = 254;
            foreach (string item in ipCombo.Items)
            {
                string subnet = item.Substring(0, item.LastIndexOf("."));
                ScanIP(subnet);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DNSQueryForm dnsQueryForm = new DNSQueryForm();
            dnsQueryForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipCombo.Items.Add(ip.ToString());
                }
            }
            ipCombo.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TracertForm tracert = new TracertForm();
            tracert.Show();
        }
        private void ScanIP(string subnet)
        {
            Task.Factory.StartNew(new Action(() =>
            {
                Parallel.For(1, 255, (i, loop) =>
                {   
                    int timeout = 100;
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingOptions pingOptions = new PingOptions(1, true);
                    PingReply reply = ping.Send(ip, timeout, new byte[] { 0 }, pingOptions);
                    if (reply.Status == IPStatus.Success)
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {

                            try
                            {
                                IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                //lvResult.Items.Add(new ListViewItem(new String[] { ip, host.HostName, "Active" }));
                                data.Rows.Add(ip, host.HostName, "Active");
                            }
                            catch (Exception ex)
                            {
                                data.Rows.Add(ip, "Unknown", "Active");

                                //lvResult.Items.Add(new ListViewItem(new String[] { ip, "Unknown", "Active" }));
                            }
                            progressBar.Value += 1;

                            if (progressBar.Value == 253)
                            {
                                lbStatus.ForeColor = Color.Green;
                                lbStatus.Text = "Finished";
                                progressBar.Value = 0;
                                button2.Enabled = true;
                            }

                        }));
                    }
                    else
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {
                            progressBar.Value += 1;

                            //lvResult.Items.Add(new ListViewItem(new String[] { ip, "", "Down" }));
                            if (progressBar.Value == 253)
                            {
                                lbStatus.ForeColor = Color.Green;
                                lbStatus.Text = "Finished";
                                progressBar.Value = 0;
                                button2.Enabled = true;
                                
                            }
                        }));
                    }
                    ping.Dispose();
                });
            }));
        }
    }
}