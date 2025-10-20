using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class PosHeader
	{
		[Key]
		public int pos_id { get; set; }
		
		public string pos_no { get; set; } = string.Empty;
		public DateTime pos_date { get; set; } = new DateTime(2001, 1, 1);
		public string customer_code { get; set; } = string.Empty;
		public string customer_name { get; set; } = string.Empty;
		public decimal total_amount { get; set; } = 0.00m;
		public decimal discount_amount { get; set; } = 0.00m;
		public decimal tax_amount { get; set; } = 0.00m;
		public decimal net_amount { get; set; } = 0.00m;
		public string payment_mode { get; set; } = string.Empty;
		public string cashier { get; set; } = string.Empty;
		public DateTime created_date { get; set; } = new DateTime(2001, 1, 1);
		public int printed { get; set; } = 0;
		public string shift_no { get; set; } = string.Empty;
		public string terminal_id { get; set; } = string.Empty;
		public decimal cash_tendered { get; set; } = 0.00m;
		public decimal change_amount { get; set; } = 0.00m;
		public string receipt_no { get; set; } = string.Empty;
		public int posted { get; set; } = 0;
		public string location { get; set; } = string.Empty;
		public string profitc { get; set; } = "x";
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.00000m;
		public int csale { get; set; } = 0;
		public string branchcode { get; set; } = string.Empty;
	}
}