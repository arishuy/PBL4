using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL4
{
    public partial class IPScanner : Form
    {
        DataTable data;
        Thread myThread = null;
        public IPScanner()
        {
            InitializeComponent();
            data = new DataTable();
            Control.CheckForIllegalCrossThreadCalls = false;
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
            btnStop.Enabled = true;
            foreach (CBBItem item in ipCombo.Items)
            {
                IPAddress subnet = GetSubNetMask(item.Value);
                    ScanIP(subnet, count, timeout, item.Value);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = (trackbar.Value*4 + 100).ToString() + "ms";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipCombo.Items.Add(new CBBItem { Value = ip });
                }
            }
            ipCombo.SelectedIndex = 0;
        }
        private async void ScanIP(IPAddress subnet, int count, int timeout, IPAddress ip)
        {
            IPAddress NA = GetNetWorkAddress(subnet, ip);
            Console.WriteLine(NA);
            IPAddress BA = GetBroadCastAddress(subnet, ip);
            Console.WriteLine(BA);
            string[] startIPString = NA.ToString().Split('.');
            int[] startIP = Array.ConvertAll<string, int>(startIPString, int.Parse); //Change string array to int array
            string[] endIPString = BA.ToString().Split('.');
            int[] endIP = Array.ConvertAll<string, int>(endIPString, int.Parse);
            
            progressBar.Minimum = 0;
            progressBar.Maximum = 1000;
            //Loops through the IP range, maxing out at 255
            await Task.Run(() =>
            {
                for (int i = startIP[2]; i <= endIP[2]; i++)
                { //3rd octet loop
                    for (int y = startIP[3]; y <= 255; y++)
                    { //4th octet loop
                        Thread myThread = new Thread(() =>
                        {
                            IPHostEntry host;
                            Ping myPing;
                            PingReply reply;
                            string ipAddress = startIP[0] + "." + startIP[1] + "." + i + "." + y; //Convert IP array back into a string
                            string endIPAddress = endIP[0] + "." + endIP[1] + "." + endIP[2] + "." + endIP[3]; // +1 is so that the scanning stops at the correct range

                            //If current IP matches final IP in range, break

                            myPing = new Ping();
                            try
                            {
                                reply = myPing.Send(ipAddress, timeout); //Ping IP address with 500ms timeout
                            }
                            catch (Exception ex)
                            {
                                return;
                            }
                            //lbStatus.ForeColor = System.Drawing.Color.Green; //Set status label for current IP address
                            //lbStatus.Text = "Scanning: " + ipAddress;
                            //Log pinged IP address in listview
                            //Grabs DNS information to obtain system info
                            if (reply.Status == IPStatus.Success)
                            {
                                try
                                {
                                    IPAddress addr = IPAddress.Parse(ipAddress);
                                    host = Dns.GetHostEntry(addr);
                                    data.Rows.Add(addr, host.HostName, "Active");
                                }
                                catch
                                {

                                    data.Rows.Add(IPAddress.Parse(ipAddress), "Unknown", "Active");
                                }
                            }
                            //else
                            //{
                            //    data.Rows.Add(ipAddress, "Unknown", "Offline");
                            //}
                            myPing.Dispose();
                           
                            
                        });
                        myThread.Start();
                        myThread.Join(timeout);
                        progressBar.Value++;
                    }
                    startIP[3] = 1; //If 4th octet reaches 255, reset back to 1
                }
            });
            progressBar.Value = 0;
            btnStop.Enabled = false;
            button2.Enabled = true;
            lbStatus.ForeColor = Color.Green;
            lbStatus.Text = "Finish";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (myThread.IsAlive == true)
            {
                myThread.Abort();
                btnStop.Enabled = false;
                button2.Enabled = true;
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Scan Stopped";
            }
        }

        private void trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            label7.Text = (trackbar.Value * 4 + 100).ToString() + "ms";
        }

        private static IPAddress GetSubNetMask(IPAddress address)
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (address.Equals(unicastIPAddressInformation.Address))
                        {
                            return unicastIPAddressInformation.IPv4Mask;
                        }
                    }
                }
            }
            throw new ArgumentException(string.Format("error"));
        }
        private static IPAddress GetNetWorkAddress(IPAddress subnet, IPAddress ip)
        {
            byte[] ipAddressBytes = ip.GetAddressBytes();
            byte[] subnetAddressBytes = subnet.GetAddressBytes();
            byte[] networkAddressBytes = new byte[ipAddressBytes.Length];
            for (int i = 0; i < networkAddressBytes.Length; i++)
            {
                networkAddressBytes[i] = (byte)(ipAddressBytes[i] & subnetAddressBytes[i]);
            }
            return new IPAddress(networkAddressBytes);
        }
        private static IPAddress GetBroadCastAddress(IPAddress subnet, IPAddress ip)
        {
            byte[] ipAddressBytes = ip.GetAddressBytes();
            byte[] subnetAddressBytes = subnet.GetAddressBytes();
            byte[] networkAddressBytes = GetNetWorkAddress(subnet, ip).GetAddressBytes();
            byte[] broadcastAddressBytes = new byte[ipAddressBytes.Length];

            for (int i = 0; i < broadcastAddressBytes.Length; i++)
            {
                broadcastAddressBytes[i] = (byte)(networkAddressBytes[i] ^ ~subnetAddressBytes[i]);
            }
            return new IPAddress(broadcastAddressBytes);
        }
    }
}