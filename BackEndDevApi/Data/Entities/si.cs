using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class si
	{
		[Key]
		public int sid { get; set; }
		public string code { get; set; }
		public string descr {  get; set; }	
	}
}
