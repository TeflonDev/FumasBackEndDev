using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class PosPaymentMode
    {
        [Key]
        public int modeid { get; set; }
        public string modename { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public int active { get; set; } = 1;
        public int require_auth { get; set; } = 0;
        public decimal min_amount { get; set; } = 0;
        public decimal max_amount { get; set; } = 999999999;
        public string account_code { get; set; } = string.Empty;
        public int allow_change { get; set; } = 1;
        public string createdby { get; set; } = string.Empty;
        public DateTime createddate { get; set; } = new DateTime(2001, 1, 1);
        public string modifiedby { get; set; } = string.Empty;
        public DateTime modifieddate { get; set; } = new DateTime(2001, 1, 1);
        public int sort_order { get; set; } = 0;
        public string icon { get; set; } = string.Empty;
        public string currency_code { get; set; } = "KES";
    }
}