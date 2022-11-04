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
using System.Windows.Controls;
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
            var topLeftHeaderCell = dataGridView1.TopLeftHeaderCell;
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data.Columns.AddRange(new DataColumn[] { new DataColumn("IP"),
                new DataColumn("Host Name"),
                new DataColumn("Status"),
            });
        }
        

        private void buttonScan_Click(object sender, EventArgs e)
        {
            int timeout = trackbar.Value * 4 + 100;
            button2.Enabled = false;
            data.Rows.Clear();
            lbStatus.ForeColor = Color.Blue;
            lbStatus.Text = "Scanning...";
            int count = 255 * ipCombo.Items.Count - 1;
            progressBar.Value = 0;
            progressBar.Maximum = count;
            foreach (string item in ipCombo.Items)
            {
                string subnet = item.Substring(0, item.LastIndexOf("."));
                ScanIP(subnet, count, timeout);
            }
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
        private async void ScanIP(string subnet, int count, int timeout)
        {
            await Task.Factory.StartNew(new Action(() =>
            {
                Parallel.For(1, 255, (i, loop) =>
                {
                    //int timeout = 100;
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingOptions pingOptions = new PingOptions(100, true);
                    PingReply reply = ping.Send(ip, timeout, new byte[] { 0 }, pingOptions);
                    if (reply.Status == IPStatus.Success)
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {

                            try
                            {
                                IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                data.Rows.Add(ip, host.HostName, "Active");
                            }
                            catch (Exception ex)
                            {
                                data.Rows.Add(ip, "Unknown", "Active");
                            }
                            progressBar.Value += 1;

                            if (progressBar.Value == count - 1)
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
                            if (progressBar.Value == count - 1)
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

        private void btnStop_Click(object sender, EventArgs e)
        {
        }

        private void trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            label7.Text = (trackbar.Value * 4 + 100).ToString() + "ms";
        }
    }
}