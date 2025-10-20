using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Adjust
	{
		[Key]
		public int aid { get; set; }
		
		public string no { get; set; } = string.Empty;
		public DateTime adate { get; set; } = new DateTime(2001, 1, 1);
		public string staff { get; set; } = string.Empty;
		public string remarks { get; set; } = string.Empty;
		public string loc { get; set; } = string.Empty;
		public string screate { get; set; } = string.Empty;
		public DateTime dcreate { get; set; } = new DateTime(2001, 1, 1);
		public int posted { get; set; } = 0;
		public int csale { get; set; } = 0;
		public string branchcode { get; set; } = string.Empty;
	}
}