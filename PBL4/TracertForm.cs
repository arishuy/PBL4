﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL4
{
    public partial class TracertForm : Form
    {
        DataTable data;
        public TracertForm()
        {
            InitializeComponent();
            label7.Text = (trackbar.Value * 4 + 100).ToString() + "ms";
            data = new DataTable();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data.Columns.AddRange(new DataColumn[] { new DataColumn("Hop ID"), new DataColumn("Address"), new DataColumn("Host Name"), new DataColumn("Reply Time"), new DataColumn("Reply status") });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            try
            {
                var progress = new Progress<TracertEntry>();
                int timeout = trackbar.Value * 4 + 100;
                progress.ProgressChanged += (s, item) =>
                {
                    data.Rows.Add(item.HopID, item.Address, item.Hostname, item.ReplyTime, item.ReplyStatus);
                };
                button1.Enabled = false;
                await Task.Run(() =>
                {
                    try
                    {
                        GetItemsAndReport(progress, textBox1.Text, Convert.ToInt32(txtMaxHops.Text), timeout);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                );
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void GetItemsAndReport(IProgress<TracertEntry> progress, string ipAddress, int maxHops, int timeout)
        {
            try
            {
                foreach (var item in Tracert(ipAddress, maxHops, timeout)) progress.Report(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private IEnumerable<TracertEntry> Tracert(string HostOrIPAddress, int maxHops, int timeout)
        {
            // Ensure that the argument address is valid.
            if (!IPAddress.TryParse(HostOrIPAddress, out IPAddress address))
            {
                try
                {
                    IPHostEntry hostInfo = Dns.GetHostEntry(HostOrIPAddress);
                    address = hostInfo.AddressList[0];
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(string.Format("{0} is not a valid address.", HostOrIPAddress));
                }
            }

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
        private void trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            label7.Text = (trackbar.Value * 4 + 100).ToString() + "ms";
        }

    }
}
