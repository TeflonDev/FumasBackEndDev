using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class ArCreditDetails
    {
        [Key]
        public int rdid { get; set; }
        public string rno { get; set; } = string.Empty;
        public string invno { get; set; } = string.Empty;
        public DateTime invdate { get; set; } = new DateTime(2001, 1, 1);
        public decimal amount { get; set; } = 0;
        public decimal amountpaid { get; set; } = 0;
        public string remarks { get; set; } = string.Empty;
        public string rtype { get; set; } = string.Empty;
        public string tcode { get; set; } = string.Empty;
        public string? srent { get; set; }
        public string? pvat { get; set; }
        public int invoiceyear { get; set; } = 0;
        public string invoicemth { get; set; } = string.Empty;
        public int invoicemthn { get; set; } = 0;
    }
}