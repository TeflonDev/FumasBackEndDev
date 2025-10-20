using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class UsersRights
	{
		[Key]
		public int rid { get; set; }
		
		public string usercode { get; set; } = string.Empty;
		public string form_name { get; set; } = string.Empty;
		public int can_view { get; set; } = 0;
		public int can_add { get; set; } = 0;
		public int can_edit { get; set; } = 0;
		public int can_delete { get; set; } = 0;
		public int can_print { get; set; } = 0;
		public int can_export { get; set; } = 0;
		public string created_by { get; set; } = string.Empty;
		public DateTime created_date { get; set; } = new DateTime(2001, 1, 1);
		public string modified_by { get; set; } = string.Empty;
		public DateTime modified_date { get; set; } = new DateTime(2001, 1, 1);
		public string branchcode { get; set; } = string.Empty;
	}
}