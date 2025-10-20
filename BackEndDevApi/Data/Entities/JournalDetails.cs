using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class JournalDetails
    {
        [Key]
        public int jtid { get; set; }
        public string code { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string remarks { get; set; } = string.Empty;
        public decimal debit { get; set; } = 0;
        public decimal credit { get; set; } = 0;
        public string no { get; set; } = string.Empty;
        public string cheqno { get; set; } = string.Empty;
        public string details { get; set; } = string.Empty;
        public string dcurrency_s { get; set; } = "KES";
        public string cperiod { get; set; } = string.Empty;
        public decimal rate { get; set; } = 1;
        public string costcenter { get; set; } = string.Empty;
        public string account { get; set; } = string.Empty;
        public string accountcode { get; set; } = string.Empty;
        public string accountname { get; set; } = string.Empty;
        public string taxable { get; set; } = "NO";
        public string inclusive { get; set; } = "NO";
        public string branch { get; set; } = string.Empty;
    }
}