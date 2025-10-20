using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class ApPrepayment
	{
		[Key]
		public int pid { get; set; }
		
		public string pno { get; set; } = string.Empty;
		public DateTime pdate { get; set; } = new DateTime(2001, 1, 1);
		public string ccode { get; set; } = string.Empty;
		public string cname { get; set; } = string.Empty;
		public decimal amount { get; set; } = 0.00m;
		public string account { get; set; } = string.Empty;
		public string cheque_no { get; set; } = string.Empty;
		public string remarks { get; set; } = string.Empty;
		public decimal balbf { get; set; } = 0.00m;
		public decimal prepaid { get; set; } = 0.00m;
		public string staff { get; set; } = string.Empty;
		public DateTime staffdate { get; set; } = new DateTime(2001, 1, 1);
		public int posted { get; set; } = 0;
		public decimal amount_paid { get; set; } = 0.00m;
		public string rtype { get; set; } = "Q";
		public DateTime tdate { get; set; } = new DateTime(2013, 1, 23);
		public string profitc { get; set; } = "x";
		public string inword { get; set; } = string.Empty;
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.0000000000m;
		public string cinvoices { get; set; } = string.Empty;
		public DateTime bdate { get; set; } = new DateTime(2013, 1, 1);
		public decimal base_rate { get; set; } = 0.00m;
		public int csale { get; set; } = 0;
		public int csale_ { get; set; } = 0;
		public string voucherno { get; set; } = string.Empty;
		public string shiftno { get; set; } = string.Empty;
		public string branchcode { get; set; } = string.Empty;
	}
}