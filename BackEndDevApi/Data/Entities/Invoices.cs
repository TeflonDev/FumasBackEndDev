using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Invoices
	{
		[Key]
		public int iid { get; set; }
		
		public string invno { get; set; } = string.Empty;
		public int posted { get; set; } = 0;
		public string CLIENTCODE { get; set; } = string.Empty;
		public DateTime invdate { get; set; } = new DateTime(2001, 1, 1);
		public decimal amount { get; set; } = 0.00m;
		public decimal amountpaid { get; set; } = 0.00m;
		public string staff { get; set; } = string.Empty;
		public DateTime staffdate { get; set; } = new DateTime(2001, 1, 1);
		public int paid { get; set; } = 0;
		public string receiptno { get; set; } = string.Empty;
		public DateTime receiptdate { get; set; } = new DateTime(2010, 1, 1);
		public int printed { get; set; } = 0;
		public string status { get; set; } = string.Empty;
		public int type { get; set; } = 0;
		public decimal credit { get; set; } = 0;
		public string linked { get; set; } = "n";
		public string clientname { get; set; } = string.Empty;
		public string source { get; set; } = "c";
		public string comments { get; set; } = string.Empty;
		public DateTime duedate { get; set; } = new DateTime(2001, 1, 1);
		public string vat { get; set; } = "0";
		public int td { get; set; } = 0;
		public decimal disc { get; set; } = 0.0000m;
		public string cost_center { get; set; } = string.Empty;
		public string vatable { get; set; } = "0";
		public decimal discount { get; set; } = 0.00m;
		public string currency { get; set; } = string.Empty;
		public string pmode { get; set; } = string.Empty;
		public decimal gtotal { get; set; } = 0.00m;
		public string loc { get; set; } = string.Empty;
		public string salesref { get; set; } = string.Empty;
		public string salesname { get; set; } = string.Empty;
		public string sheetno { get; set; } = string.Empty;
		public string orderno { get; set; } = string.Empty;
		public string branch { get; set; } = string.Empty;
		public DateTime datefrom { get; set; } = new DateTime(2010, 1, 1, 1, 1, 1);
		public DateTime dateto { get; set; } = new DateTime(2010, 1, 1, 1, 1, 1);
		public int csale { get; set; } = 0;
		public string delivery { get; set; } = string.Empty;
		public string branchname { get; set; } = string.Empty;
		public string incheque_no { get; set; } = string.Empty;
		public string incheque_date { get; set; } = string.Empty;
		public string lpo { get; set; } = string.Empty;
		public string amt_word { get; set; } = string.Empty;
		public string cexchange { get; set; } = "Invoice";
		public string profitc { get; set; } = string.Empty;
		public int gpenalty { get; set; } = 1;
		public decimal mtotal { get; set; } = 0.00m;
		public decimal mvar { get; set; } = 0.00m;
		public decimal reprint { get; set; } = 0;
		public string cperiod { get; set; } = "201304";
		public string dcurrency_s { get; set; } = "KES";
		public decimal rate { get; set; } = 1.0000000000m;
		public int jr { get; set; } = 0;
		public int pr { get; set; } = 0;
		public string otherref { get; set; } = string.Empty;
		public string footer { get; set; } = string.Empty;
		public string roomno { get; set; } = string.Empty;
		public string foliono { get; set; } = string.Empty;
		public string guestcode { get; set; } = string.Empty;
		public string guestname { get; set; } = string.Empty;
		public string boardtype { get; set; } = string.Empty;
		public string shiftno { get; set; } = string.Empty;
		public string loader { get; set; } = string.Empty;
		public string branchcode11 { get; set; } = string.Empty;
		public string rctno { get; set; } = string.Empty;
		public int submitted { get; set; } = 0;
		public string branchcode { get; set; } = string.Empty;
		public string branchcode1 { get; set; } = string.Empty;
	}
}