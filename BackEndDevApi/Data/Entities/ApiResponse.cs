namespace BackEndDevApi.Data.Entities
{
	public class ApiResponse<T>
	{
		public string message { get; set; } = string.Empty;
		public bool result { get; set; } = true;
		public List<T> data { get; set; } = new List<T>();
	}
}