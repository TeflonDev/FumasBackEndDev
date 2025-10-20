using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Cashout
	{
		[Key]
		public int cid { get; set; }
		
		public string refno { get; set; } = string.Empty;
		public string staffname { get; set; } = string.Empty;
		public DateTime transdate { get; set; } = new DateTime(2001, 1, 1);
		public decimal amount { get; set; } = 0.00m;
		public int posted { get; set; } = 0;
		public string staff { get; set; } = string.Empty;
		public DateTime staffdate { get; set; } = new DateTime(2001, 1, 1);
		public string takenby { get; set; } = string.Empty;
		public string account { get; set; } = string.Empty;
		public string bankingto { get; set; } = string.Empty;
		public string remarks { get; set; } = string.Empty;
		public string shiftno { get; set; } = string.Empty;
		public string profitc { get; set; } = string.Empty;
	}
}