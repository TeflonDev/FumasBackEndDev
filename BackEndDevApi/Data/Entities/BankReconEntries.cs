using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class BankReconEntries
    {
        [Key]
        public int brid { get; set; }
        public DateTime brdate { get; set; } = new DateTime(2001, 1, 1);
        public int brtype { get; set; } = 0;
        public string descr { get; set; } = string.Empty;
        public string bank { get; set; } = string.Empty;
        public string alloc_acct { get; set; } = string.Empty;
        public int posted { get; set; } = 0;
        public decimal amount { get; set; } = 0;
        public string createdby { get; set; } = string.Empty;
        public DateTime createddate { get; set; } = new DateTime(2001, 1, 1);
        public string modifiedby { get; set; } = string.Empty;
        public DateTime modifieddate { get; set; } = new DateTime(2001, 1, 1);
        public string refno { get; set; } = string.Empty;
        public int csale { get; set; } = 0;
        public string dcurrency_s { get; set; } = "KES";
        public string cperiod { get; set; } = string.Empty;
        public decimal rate { get; set; } = 1;
        public string costcenter { get; set; } = string.Empty;
    }
}