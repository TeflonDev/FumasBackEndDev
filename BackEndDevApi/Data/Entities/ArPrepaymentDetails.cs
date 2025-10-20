using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class ArPrepaymentDetails
    {
        [Key]
        public int rdid { get; set; }
        public string rno { get; set; } = string.Empty;
        public string invno { get; set; } = string.Empty;
        public DateTime invdate { get; set; } = new DateTime(2001, 1, 1);
        public decimal amount { get; set; } = 0;
        public decimal amountpaid { get; set; } = 0;
        public string remarks { get; set; } = string.Empty;
        public decimal rate { get; set; } = 1;
        public string reference { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string sales_ref { get; set; } = string.Empty;
        public string sales_name { get; set; } = string.Empty;
        public decimal com { get; set; } = 0;
        public string idid { get; set; } = string.Empty;
        public string cname { get; set; } = string.Empty;
    }
}