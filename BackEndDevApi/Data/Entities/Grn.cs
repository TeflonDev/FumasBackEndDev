using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Grn
	{
		[Key]
		public int gid { get; set; }
		
		public string no { get; set; } = string.Empty;
		public string scode { get; set; } = string.Empty;
		public string sname { get; set; } = string.Empty;
		public DateTime gdate { get; set; } = new DateTime(2001, 1, 1);
		public DateTime ddate { get; set; } = new DateTime(2001, 1, 1);
		public string loc { get; set; } = string.Empty;
		public string remarks { get; set; } = string.Empty;
		public int posted { get; set; } = 0;
		public string screate { get; set; } = string.Empty;
		public DateTime dcreate { get; set; } = new DateTime(2001, 1, 1);
		public string spost { get; set; } = string.Empty;
		public DateTime dpost { get; set; } = new DateTime(2001, 1, 1);
		public int st { get; set; } = 0;
		public string accounts { get; set; } = string.Empty;
		public string requistion { get; set; } = string.Empty;
		public string lpo { get; set; } = string.Empty;
		public DateTime vdate { get; set; } = new DateTime(2001, 1, 1);
		public DateTime vddate { get; set; } = new DateTime(2001, 1, 1);
		public string period { get; set; } = string.Empty;
		public decimal vat { get; set; } = 0.0000m;
		public string vatable { get; set; } = string.Empty;
		public decimal totalvalue { get; set; } = 0.0000m;
		public decimal others { get; set; } = 0.0000m;
		public string taxinc { get; set; } = string.Empty;
		public string service { get; set; } = string.Empty;
		public string district { get; set; } = string.Empty;
		public string reason { get; set; } = string.Empty;
		public int invoiced { get; set; } = 0;
		public string profitc { get; set; } = "x";
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.00000m;
		public string branchcode { get; set; } = string.Empty;
	}
}