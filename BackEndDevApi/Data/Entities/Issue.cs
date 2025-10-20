using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Issue
	{
		[Key]
		public int aid { get; set; }
		
		public string no { get; set; } = string.Empty;
		public DateTime adate { get; set; } = new DateTime(2001, 1, 1);
		public string staff { get; set; } = string.Empty;
		public string remarks { get; set; } = string.Empty;
		public string loc { get; set; } = string.Empty;
		public string screate { get; set; } = string.Empty;
		public DateTime dcreate { get; set; } = new DateTime(2001, 1, 1);
		public int posted { get; set; } = 0;
		public string spost { get; set; } = string.Empty;
		public DateTime dpost { get; set; } = new DateTime(2001, 1, 1);
		public int invoiced { get; set; } = 0;
		public string orderno { get; set; } = string.Empty;
		public string salesref { get; set; } = string.Empty;
		public string salesname { get; set; } = string.Empty;
		public string ccode { get; set; } = string.Empty;
		public string cname { get; set; } = string.Empty;
		public string profitc { get; set; } = "x";
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.00000m;
		public int csale { get; set; } = 0;
		public string branchcode { get; set; } = string.Empty;
	}
}