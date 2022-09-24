namespace PBL4
{
    internal class TracertEntry
    {
        public TracertEntry()
        {
        }

        public int HopID { get; set; }
        public string Address { get; set; }
        public string Hostname { get; set; }
        public long ReplyTime { get; set; }
        public string ReplyStatus { get; set; }

        public override string ToString()
        {
            return HopID.ToString() + "\t" + Address.ToString() + "\t" + Hostname.ToString() + "\t" + ReplyTime.ToString() + "\t" + ReplyStatus.ToString();
        }
    }
}