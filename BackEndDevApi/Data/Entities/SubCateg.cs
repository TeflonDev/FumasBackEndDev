using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class SubCateg
	{
		[Key]
		public string code { get; set; }
		public string descr { get; set; }
		public decimal? lastprice { get; set; } = 0.00m;
		public decimal? wholesale { get; set; } = 0.00m;
		public decimal? sellingprice { get; set; } = 0.00m;
		public string? main_categ { get; set; } = string.Empty;
		public int? clist { get; set; } = 0;
		public int? yy { get; set; } = 0;
		public int? pp { get; set; } = 0;
		
		public int? id { get; set; } = 0;
	}
}
