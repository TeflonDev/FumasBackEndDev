using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class ApPrepaymentDetails
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
        public decimal totalwithholding_ { get; set; } = 0;
        public decimal withholdingpaid_ { get; set; } = 0;
    }
}