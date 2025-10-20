using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Quotations
	{
		[Key]
		public int qid { get; set; }
		
		public string no { get; set; } = string.Empty;
		public string scode { get; set; } = string.Empty;
		public string sname { get; set; } = string.Empty;
		public DateTime qdate { get; set; } = new DateTime(2001, 1, 1);
		public DateTime vdate { get; set; } = new DateTime(2001, 1, 1);
		public string screate { get; set; } = string.Empty;
		public DateTime dcreate { get; set; } = new DateTime(2001, 1, 1);
		public string description { get; set; } = string.Empty;
		public decimal amount { get; set; } = 0.00m;
		public int printed { get; set; } = 0;
		public string profitc { get; set; } = "x";
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.00000m;
		public string branchcode { get; set; } = string.Empty;
	}
}