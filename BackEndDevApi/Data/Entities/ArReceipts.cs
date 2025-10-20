using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class ArReceipts
	{
		[Key]
		public int rid { get; set; }
		
		public string clientcode { get; set; } = string.Empty;
		public DateTime rdate { get; set; } = new DateTime(2001, 1, 1);
		public string account { get; set; } = string.Empty;
		public decimal amount { get; set; } = 0.00m;
		public string rno { get; set; } = string.Empty;
		public float allocate { get; set; } = 0;
		public string staffname { get; set; } = string.Empty;
		public DateTime staffdate { get; set; } = new DateTime(2001, 1, 1);
		public string cheque { get; set; } = string.Empty;
		public decimal balbf { get; set; } = 0.00m;
		public decimal amtav { get; set; } = 0.00m;
		public int bounced { get; set; } = 0;
		public int banked { get; set; } = 0;
		public string b_by { get; set; } = string.Empty;
		public DateTime b_d { get; set; } = new DateTime(2001, 1, 1);
		public string b_to { get; set; } = string.Empty;
		public string b_ref { get; set; } = string.Empty;
		public int posted { get; set; } = 1;
		public string details { get; set; } = string.Empty;
		public string regno { get; set; } = string.Empty;
		public string make { get; set; } = string.Empty;
		public string model { get; set; } = string.Empty;
		public string engine { get; set; } = string.Empty;
		public string amtinwords { get; set; } = string.Empty;
		public string rtype { get; set; } = string.Empty;
		public string salesref { get; set; } = string.Empty;
		public string salesname { get; set; } = string.Empty;
		public string sheetno { get; set; } = string.Empty;
		public string clientname { get; set; } = string.Empty;
		public string profitc { get; set; } = "x";
	}
}