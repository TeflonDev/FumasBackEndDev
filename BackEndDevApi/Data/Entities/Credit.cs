using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Credit
	{
		[Key]
		public int iid { get; set; }
		
		public string invno { get; set; } = string.Empty;
		public string clientcode { get; set; } = string.Empty;
		public DateTime invdate { get; set; } = new DateTime(2001, 1, 1);
		public string staff { get; set; } = string.Empty;
		public DateTime staffdate { get; set; } = new DateTime(2001, 1, 1);
		public int paid { get; set; } = 0;
		public string receiptno { get; set; } = string.Empty;
		public DateTime receiptdate { get; set; } = new DateTime(2001, 1, 1);
		public int printed { get; set; } = 0;
		public decimal amount { get; set; } = 0.00m;
		public string status { get; set; } = string.Empty;
		public decimal amountpaid { get; set; } = 0.00m;
		public int type { get; set; } = 0;
		public decimal credit_amount { get; set; } = 0;
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
		public int posted { get; set; } = 0;
		public decimal gtotal { get; set; } = 0.00m;
		public string loc { get; set; } = "STORE";
		public string salesref { get; set; } = string.Empty;
		public string salesname { get; set; } = string.Empty;
		public string sheetno { get; set; } = string.Empty;
		public string orderno { get; set; } = string.Empty;
		public string branch { get; set; } = string.Empty;
		public int invoiced { get; set; } = 0;
		public string grnno { get; set; } = string.Empty;
		public int rmode { get; set; } = 0;
		public int csale { get; set; } = 0;
		public string cexchange { get; set; } = "Credit Note";
		public string profitc { get; set; } = "x";
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.0000000000m;
		public int jr { get; set; } = 0;
		public int pr { get; set; } = 0;
		public string roomno { get; set; } = string.Empty;
		public string spost { get; set; } = string.Empty;
		public string dpost { get; set; } = string.Empty;
		public string invoice { get; set; } = string.Empty;
		public string shiftno { get; set; } = string.Empty;
		public string loader { get; set; } = string.Empty;
		public string cu_invoice_number { get; set; } = string.Empty;
		public string branchcode { get; set; } = string.Empty;
	}
}