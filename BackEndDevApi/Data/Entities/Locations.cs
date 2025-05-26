using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Locations

	{
		[Key]
		public string code { get; set; }
		public string descr { get; set; }

		public int? clist { get; set; }
		public string? itemcode { get; set; }
		public string? itemname { get; set; }
		public string? profitc { get; set; }
		public DateTime? last_updated { get; set; }
		public int? id { get; set; }	
	}
}
