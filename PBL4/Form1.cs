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
            data = new DataTable();
            
            label2.Text = "";
            String myping = textBox1.Text;
            if (myping == "")
            {
                MessageBox.Show("Please enter a valid IP address");
            }
            else
            {
                Ping p1 = new Ping();
                PingReply PR = p1.Send(myping);
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
            data.Rows.Clear();
            string subnet = txtIP.Text.Substring(0, txtIP.Text.LastIndexOf("."));
            progressBar.Maximum = 254;
            progressBar.Value = 0;
            lbStatus.ForeColor = Color.Blue;
            lbStatus.Text = "Scanning...";
            ScanIP(subnet);
        }
        private void button3_Click(object sender, EventArgs e)
        {

            tbdns.Text = "";
            //throw new InvalidOperationException("Unable to find DNS Address");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                if (dnsServers.Count > 0)
                {
                    tbdns.Text+=adapter.Description;
                    tbdns.Text += Environment.NewLine;
                    foreach (IPAddress dns in dnsServers)
                    {
                        Console.WriteLine("  DNS Servers  : {0}",
                            dns.ToString());
                        tbdns.Text += "  DNS Servers  : " + dns.ToString();
                        tbdns.Text += Environment.NewLine;
                    }
                    Console.WriteLine();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtIP.Text = ip.ToString();
                }
            }
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
                Parallel.For(2, 255, (i, loop) =>
                //for (int i = 2; i < 255; i++)
                {
                    int timeout = 500;
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
                            catch (SocketException ex)
                            {
                                data.Rows.Add(ip, "Unknown", "Active");

                                //lvResult.Items.Add(new ListViewItem(new String[] { ip, "Unknown", "Active" }));
                            }
                            progressBar.Value += 1;

                            if (progressBar.Value == 253)
                            {
                                lbStatus.ForeColor = Color.Green;
                                lbStatus.Text = "Finished";
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
                            }
                        }));
                    }
                });
            }));
        }
    }
}