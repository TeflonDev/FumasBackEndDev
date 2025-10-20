using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class CompanySettings
	{
		[Key]
		public string name { get; set; } = string.Empty;
		
		public string address { get; set; } = string.Empty;
		public string pin { get; set; } = string.Empty;
		public string vat { get; set; } = string.Empty;
		public string tel { get; set; } = string.Empty;
		public string fax { get; set; } = string.Empty;
		public string footer { get; set; } = string.Empty;
		public string membership { get; set; } = string.Empty;
		public string email { get; set; } = string.Empty;
	}
}