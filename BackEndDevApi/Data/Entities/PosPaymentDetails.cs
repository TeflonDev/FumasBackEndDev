using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class PosPaymentDetails
    {
        [Key]
        public int paymentid { get; set; }
        public int orderid { get; set; } = 0;
        public string paymentmethod { get; set; } = string.Empty;
        public decimal amount { get; set; } = 0;
        public DateTime paymentdate { get; set; } = new DateTime(2001, 1, 1);
        public string reference { get; set; } = string.Empty;
        public int status { get; set; } = 0;
        public string createdby { get; set; } = string.Empty;
        public DateTime createddate { get; set; } = new DateTime(2001, 1, 1);
        public string modifiedby { get; set; } = string.Empty;
        public DateTime modifieddate { get; set; } = new DateTime(2001, 1, 1);
        public string notes { get; set; } = string.Empty;
        public decimal change_amount { get; set; } = 0;
        public string currency { get; set; } = "KES";
        public decimal exchange_rate { get; set; } = 1;
    }
}