using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL4
{
    public partial class TracertForm : Form
    {
        public TracertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                foreach(TracertEntry tracertEntry in Tracert(textBox1.Text, 100, 100))
                {
                    listView1.Items.Add(new ListViewItem(new String[]
                    {
                        tracertEntry.HopID.ToString(),
                        tracertEntry.Address.ToString(),
                        tracertEntry.Hostname.ToString(),
                        tracertEntry.ReplyTime.ToString(),
                        tracertEntry.ReplyStatus.ToString(),
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private IEnumerable<TracertEntry> Tracert(string ipAddress, int maxHops, int timeout)
        {
            // Ensure that the argument address is valid.
            if (!IPAddress.TryParse(ipAddress, out IPAddress address))
                throw new ArgumentException(string.Format("{0} is not a valid IP address.", ipAddress));

            // Max hops should be at least one or else there won't be any data to return.
            if (maxHops < 1)
                throw new ArgumentException("Max hops can't be lower than 1.");

            // Ensure that the timeout is not set to 0 or a negative number.
            if (timeout < 1) throw new ArgumentException("Timeout value must be higher than 0."); 
            Ping ping = new Ping(); 
            PingOptions pingOptions = new PingOptions(1, true); 
            Stopwatch pingReplyTime = new Stopwatch(); 
            PingReply reply;
            do
            {
                pingReplyTime.Start(); 
                reply = ping.Send(address, timeout, new byte[] { 0 }, pingOptions); 
                pingReplyTime.Stop(); 
                string hostname = string.Empty; 
                if (reply.Address != null)
                {
                    try
                    {
                        IPHostEntry ipHostInfo = Dns.GetHostEntry(IPAddress.Parse(reply.Address.ToString()));
                        hostname = ipHostInfo.HostName;
                        Console.WriteLine(hostname);
                                                                                                                                      
                    }
                    catch (SocketException) { /* No host available for that address. */ }
                }

                // Return out TracertEntry object with all the information about the hop.
                yield return new TracertEntry()
                {
                    HopID = pingOptions.Ttl,
                    Address = reply.Address == null ? "N/A" : reply.Address.ToString(),
                    Hostname = hostname,
                    ReplyTime = pingReplyTime.ElapsedMilliseconds,
                    ReplyStatus = reply.Status.ToString(),
                };
                pingOptions.Ttl++;
                pingReplyTime.Reset();
            }
            while (reply.Status != IPStatus.Success && pingOptions.Ttl <= maxHops);
        }
    }
}
