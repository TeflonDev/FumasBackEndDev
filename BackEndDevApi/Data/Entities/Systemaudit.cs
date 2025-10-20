using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Systemaudit
	{
		[Key]
		public int aid { get; set; }
		
		public string username { get; set; } = string.Empty;
		public DateTime adate { get; set; } = new DateTime(2001, 1, 1);
		public string activity { get; set; } = string.Empty;
		public string details { get; set; } = string.Empty;
		public string ipaddress { get; set; } = string.Empty;
		public string macaddress { get; set; } = string.Empty;
		public string computername { get; set; } = string.Empty;
		public string module { get; set; } = string.Empty;
		public string action_type { get; set; } = string.Empty;
		public string reference_no { get; set; } = string.Empty;
		public string branchcode { get; set; } = string.Empty;
	}
}