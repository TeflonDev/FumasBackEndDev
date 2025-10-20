using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class UsersRoles
	{
		[Key]
		public int role_id { get; set; }
		
		public string role_name { get; set; } = string.Empty;
		public string role_description { get; set; } = string.Empty;
		public int is_active { get; set; } = 1;
		public string created_by { get; set; } = string.Empty;
		public DateTime created_date { get; set; } = new DateTime(2001, 1, 1);
		public string modified_by { get; set; } = string.Empty;
		public DateTime modified_date { get; set; } = new DateTime(2001, 1, 1);
		public string permissions { get; set; } = string.Empty;
		public int is_system_role { get; set; } = 0;
		public string branchcode { get; set; } = string.Empty;
	}
}