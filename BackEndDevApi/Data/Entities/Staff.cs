using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Staff
	{
		[Key]
		public int cid { get; set; }

		public string? code { get; set; } = string.Empty;
		public string? names { get; set; } = string.Empty;
		public string? tel1 { get; set; } = string.Empty;
		public string? tel2 { get; set; } = string.Empty;
		public string? p_address { get; set; } = string.Empty;
		public string? phy_address { get; set; } = string.Empty;
		public string? email { get; set; } = string.Empty;

		public string? dept1 { get; set; } = string.Empty;
		public string? dept2 { get; set; } = string.Empty;
		public string? dept3 { get; set; } = string.Empty;
		public string? dept4 { get; set; } = string.Empty;

		public string? passport { get; set; } = string.Empty;
		public string? dl { get; set; } = string.Empty;
		public string? cellphone { get; set; } = string.Empty;

		public int? w_limit { get; set; } = 0;
		public int? c_limit { get; set; } = 0;

		public bool? active { get; set; } = true;
		public bool? cr { get; set; } = false;
		public bool? cm { get; set; } = false;

		public string? country { get; set; } = string.Empty;
		public string? cate { get; set; } = string.Empty;
		public int? raw_m { get; set; } = 1;

		public string? title { get; set; } = string.Empty;
		public string? department { get; set; } = string.Empty;
		public string? Specialty { get; set; } = string.Empty;

		public decimal? target { get; set; } = 0.00m;
		public string? licenseno { get; set; } = string.Empty;
		public string? qualified { get; set; } = string.Empty;

		public DateTime? dob { get; set; } = new DateTime(2013, 1, 1);
		public DateTime? dlicence { get; set; } = new DateTime(2013, 1, 1);

		public string? joblevel { get; set; } = "NOT DEFINED";
		public string? drivingno { get; set; } = string.Empty;
		public string? usercode { get; set; } = string.Empty;
		public string? comlist { get; set; } = string.Empty;
	}
}
