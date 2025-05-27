using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Locations

	{
		[Key]
		public string code { get; set; }
		public string descr { get; set; }

		public int? clist { get; set; } =0;
		public string? itemcode { get; set; } = string.Empty;
		public string? itemname { get; set; } = string.Empty;
		public string? profitc { get; set; } = string.Empty;
		public DateTime? last_updated { get; set; } = DateTime.Now;
		public int? id { get; set; }	
	}
}
