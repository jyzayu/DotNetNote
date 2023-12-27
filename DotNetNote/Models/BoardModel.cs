namespace DotNetNote.Models
{
    public class BoardModel
    {
        public uint Idx { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public uint Reg_User { get; set; }
        public string Reg_Username { get; set; }
        public DateTime Reg_Date { get; set; }
        public uint View_Cnt { get; set; }
        public short Status_Flag { get; set; }
    }
}
