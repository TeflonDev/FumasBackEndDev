

using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Users
	{
		[Key]
		public int userid { get; set; }
		
		public string usercode { get; set; }
		public string username { get; set; }
		public string Password { get; set; } = string.Empty;
		public string CreatedBy { get; set; } = string.Empty;
		public DateTime CreatedDate { get; set; } = new DateTime(2001, 1, 1);
		public string ModifiedBy { get; set; } = string.Empty;
		public DateTime ModifiedDate { get; set; } = new DateTime(2001, 1, 1);
		public string CLevel { get; set; } = "User";
		public string CLocation { get; set; } = string.Empty;
		public int Yy { get; set; } = 0;
		public int Yytt { get; set; } = 0;
		public int Lolo { get; set; } = 0;
		public string WebPassword { get; set; } = string.Empty;
		public string UserEmail { get; set; } = string.Empty;
		public string Pin { get; set; } = string.Empty;
		public string ViewLocation { get; set; } = string.Empty;
		public string ProdProcess { get; set; } = string.Empty;
		public string ClientCode { get; set; } = string.Empty;
		public int Allow_Invoicing { get; set; } = 0;
		public int Allow_Sales { get; set; } = 0;
		public int Allow_Orders { get; set; } = 0;
		public int Allow_Delivery { get; set; } = 0;
		public string ViewLocations { get; set; } = string.Empty;
		public string ProfitC { get; set; } = string.Empty;
		public int Allow_Reports { get; set; } = 0;
		public string LoadingProfitC { get; set; } = string.Empty;
		public string LoadingLoc { get; set; } = string.Empty;
	}
}
