using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Commissionlist
	{
		[Key]
		public int stid { get; set; }
		
		public string no { get; set; } = string.Empty;
		public DateTime sdate { get; set; } = new DateTime(2001, 1, 1);
		public string loc { get; set; } = string.Empty;
		public decimal amount { get; set; } = 0.00m;
		public string staff { get; set; } = string.Empty;
		public int posted { get; set; } = 0;
		public DateTime staffdate { get; set; } = new DateTime(2001, 1, 1);
		public decimal amount2 { get; set; } = 0.00m;
		public int ALLItems { get; set; } = 0;
		public int cdisc { get; set; } = 0;
		public decimal discount { get; set; } = 0.00m;
		public decimal percent { get; set; } = 0.00m;
		public decimal percent2 { get; set; } = 0.00m;
		public decimal uprice { get; set; } = 0.000000m;
	}
}