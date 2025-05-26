using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class SubCateg
	{
		
		public string code { get; set; }
		public string descr { get; set; }
		public decimal? lastprice { get; set; }
		public decimal? wholesale { get; set; }
		public decimal? sellingprice { get; set; }	
		public string? main_categ { get; set; }	
		public int? clist { get; set; }
		public int? yy { get; set; }
		public int? pp { get; set; }
		[Key]
		public int? id { get; set; }	
	}
}
