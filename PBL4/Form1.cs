using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
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
            if (myping == "")
            {
                MessageBox.Show("Please enter a valid IP address");
            }
            else
            {
                Ping p1 = new Ping();
                PingReply PR = p1.Send(myping);
                label2.ForeColor = Color.Green;
                label2.Text = PR.Status.ToString();
                p1.Dispose();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string subnet = txtIP.Text.Substring(0, txtIP.Text.LastIndexOf("."));
            progressBar.Maximum = 254;
            progressBar.Value = 0;
            lvResult.Items.Clear();
            lbStatus.ForeColor = Color.Blue;
            lbStatus.Text = "Scanning...";
            //Task.Factory.StartNew(new Action(() =>
            //{
            Parallel.For(2, 255, (i) =>
            //for (int i = 2; i < 255; i++)
                {
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ip, 100);

                    if (reply.Status == IPStatus.Success)
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {

                            try
                            {
                                IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                lvResult.Items.Add(new ListViewItem(new String[] { ip, host.HostName, "Active" }));
                            }
                            catch
                            {
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

            //lbCount.Text = lvResult.Items.Count.ToString();

            //}));
            //try
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        List<ListIP> result = new List<ListIP>();

            //        Thread thread = new Thread(() =>
            //        {
            //            List<string> ips = new List<string>();

            //            for (int j = (255 / 10) * i + 2; j < (255 / 10) * (i + 1) + 2; j++)
            //            {
            //                string ip = $"{subnet}.{j}";
            //                ips.Add(ip);
            //            }
            //            PingThread pingThread = new PingThread(ips);
            //            result.AddRange(pingThread.Run());
            //            Console.WriteLine(result);

            //        });

            //        thread.Start();
            //        lvResult.Items.AddRange(result.Select(x => new ListViewItem(new string[] { x.ip, x.hostname, x.status })).ToArray());

            //    }
            //}
            //catch(Exception ex) { }
        }
        private void button3_Click(object sender, EventArgs e)
        {


            //throw new InvalidOperationException("Unable to find DNS Address");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                if (dnsServers.Count > 0)
                {
                    Console.WriteLine(adapter.Description);
                    foreach (IPAddress dns in dnsServers)
                    {
                        Console.WriteLine("  DNS Servers ............................. : {0}",
                            dns.ToString());
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
    }
}