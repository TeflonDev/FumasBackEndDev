using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class ArPrepayment
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
		public string salesref { get; set; } = string.Empty;
		public string salesname { get; set; } = string.Empty;
		public string sheetno { get; set; } = string.Empty;
		public string rtype { get; set; } = "Cash";
		public string inword { get; set; } = string.Empty;
		public decimal amount_paid { get; set; } = 0.00m;
		public DateTime bdate { get; set; } = new DateTime(2011, 11, 1);
		public string cinvoices { get; set; } = string.Empty;
		public int csale { get; set; } = 0;
		public string profitc { get; set; } = "x";
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.0000000000m;
		public int csale_ { get; set; } = 0;
		public int banked { get; set; } = 0;
		public string bankname { get; set; } = string.Empty;
		public string branchname { get; set; } = string.Empty;
		public string roomno { get; set; } = string.Empty;
		public string foliono { get; set; } = string.Empty;
		public string shiftno { get; set; } = string.Empty;
		public string cdeposit { get; set; } = string.Empty;
		public string depositfor { get; set; } = string.Empty;
		public string draweracctno { get; set; } = string.Empty;
		public string banked_accountcode { get; set; } = string.Empty;
		public string banked_accountname { get; set; } = string.Empty;
		public int main_prepaymentdays { get; set; } = 20;
		public string branchcode { get; set; } = string.Empty;
		public int isbulk { get; set; } = 0;
	}
}