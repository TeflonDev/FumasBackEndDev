using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Stran
	{
		[Key]
		public int sid { get; set; }
		
		public string code { get; set; } = string.Empty;
		public string description { get; set; } = string.Empty;
		public decimal balance { get; set; } = 0.00m;
		public DateTime sdate { get; set; } = new DateTime(2001, 1, 1);
		public string loc { get; set; } = string.Empty;
		public decimal cqty { get; set; } = 0.00m;
		public decimal cprice { get; set; } = 0.00m;
		public decimal qty { get; set; } = 0.00m;
		public decimal price { get; set; } = 0.00m;
		public decimal total { get; set; } = 0.00m;
		public string trantype { get; set; } = string.Empty;
		public string no { get; set; } = string.Empty;
		public string staff { get; set; } = string.Empty;
		public DateTime staffdate { get; set; } = new DateTime(2001, 1, 1);
		public string transign { get; set; } = string.Empty;
		public string source { get; set; } = string.Empty;
		public string pu { get; set; } = string.Empty;
		public decimal unitprice { get; set; } = 0.00m;
		public string batchno { get; set; } = string.Empty;
		public string serialno { get; set; } = string.Empty;
		public DateTime expdate { get; set; } = new DateTime(2017, 12, 12);
		public string location { get; set; } = string.Empty;
		public string profitc { get; set; } = "x";
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.00000m;
		public int csale { get; set; } = 0;
		public string branchcode { get; set; } = string.Empty;
	}
}