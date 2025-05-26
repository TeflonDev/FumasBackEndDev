using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Categ
	{
		[Key]
		public int id { get; set; }

		public string code { get; set; } = string.Empty;
		public string descr { get; set; } = string.Empty;

		public decimal? lastprice { get; set; } = 0.00m;
		public decimal? wholesale { get; set; } = 0.00m;
		public decimal? sellingprice { get; set; } = 0.00m;

		public string? main_categ { get; set; } = "None";
		public string clist { get; set; } = "0";

		public string posprinter { get; set; } = string.Empty;

		public int? CheckQty { get; set; } = 1;
		public int nbelows { get; set; } = 1;
		public int exp_direct { get; set; } = 0;
		public int allow_minqty { get; set; } = 0;

		public decimal order_minqty { get; set; } = 0.00m;
		public int ubfeet { get; set; } = 0;

		public decimal minbfeetqty1 { get; set; } = 0.00m;
		public decimal maxbfeetqty1 { get; set; } = 0.00m;
		public decimal minbfeetqty2 { get; set; } = 0.00m;
		public decimal maxbfeetqty2 { get; set; } = 0.00m;

		public string inputunits { get; set; } = string.Empty;
		public string sellingunits { get; set; } = string.Empty;

		public decimal conversionrate { get; set; } = 1.00m;
	}
}
