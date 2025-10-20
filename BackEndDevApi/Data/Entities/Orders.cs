using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Orders
	{
		[Key]
		public int iid { get; set; }
		
		public string invno { get; set; } = string.Empty;
		public int posted { get; set; } = 0;
		public int jr { get; set; } = 0;
		public string CLIENTCODE { get; set; } = string.Empty;
		public DateTime invdate { get; set; } = new DateTime(2001, 1, 1);
		public decimal amount { get; set; } = 0.00m;
		public decimal amountpaid { get; set; } = 0.00m;
		public decimal mvar { get; set; } = 0.00m;
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
		public decimal disc { get; set; } = 0.00m;
		public string cost_center { get; set; } = string.Empty;
		public string vatable { get; set; } = "0";
		public decimal discount { get; set; } = 0.00m;
		public string currency { get; set; } = string.Empty;
		public string pmode { get; set; } = string.Empty;
		public decimal gtotal { get; set; } = 0.00m;
		public string loc { get; set; } = "STORE";
		public decimal mtotal { get; set; } = 0.00m;
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
		public int invoiced { get; set; } = 0;
		public string cexchange { get; set; } = "Orders";
		public string profitc { get; set; } = "x";
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.000000m;
		public string lpo { get; set; } = string.Empty;
		public string amt_word { get; set; } = string.Empty;
		public decimal reprint { get; set; } = 0;
		public string footer { get; set; } = string.Empty;
		public string reason { get; set; } = string.Empty;
		public string astaff { get; set; } = string.Empty;
		public DateTime adate { get; set; } = new DateTime(2021, 1, 1);
		public string rctno { get; set; } = string.Empty;
		public string branchcode { get; set; } = string.Empty;
	}
}