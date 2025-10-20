using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class BankTransfer
	{
		[Key]
		public int jid { get; set; }
		
		public string code { get; set; } = string.Empty;
		public string description { get; set; } = string.Empty;
		public int posted { get; set; } = 0;
		public decimal debit { get; set; } = 0.00m;
		public decimal credit { get; set; } = 0.00m;
		public DateTime jdate { get; set; } = new DateTime(2001, 1, 1);
		public string staff { get; set; } = string.Empty;
		public DateTime staffdate { get; set; } = new DateTime(2001, 1, 1);
		public int recr { get; set; } = 0;
		public string cheque_no { get; set; } = string.Empty;
		public int csale { get; set; } = 0;
		public string profitc { get; set; } = "x";
	}
}