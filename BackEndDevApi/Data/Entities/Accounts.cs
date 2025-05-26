using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Accounts
	
		{
			[Key]
			public int aid { get; set; }

			public string code { get; set; } = string.Empty;

			public string? description { get; set; }

			public bool? active { get; set; } = true;

			public string type { get; set; } = "Other Current Assets";

			public decimal? balance { get; set; } = 0.00m;

			public string remarks { get; set; } = string.Empty;

			public decimal prepaid { get; set; } = 0.00m;

			public string nb { get; set; } = "Other Current Assets";

			public decimal r_amt { get; set; } = 0.00m;

			public byte? car { get; set; } = 0;

			public byte? dc { get; set; } = 1;

			public int? default_amt { get; set; } = 0;

			public int? callowmulti { get; set; } = 0;

			public string category { get; set; } = string.Empty;

			public string control_ac { get; set; } = string.Empty;

			public string cost_center { get; set; } = string.Empty;

			public decimal Pcredit { get; set; } = 0.00m;

			public string maccountcode { get; set; } = string.Empty;

			public string defaultprofitc { get; set; } = string.Empty;

			public string dcurrency_s { get; set; } = string.Empty;

			public string maccountname { get; set; } = string.Empty;

			public string ccostcenter { get; set; } = string.Empty;

			public int Cvatable { get; set; } = 0;

			public int level { get; set; } = 1;

			public string hscode { get; set; } = string.Empty;

			public string shopid { get; set; } = string.Empty;

			public DateTime last_updated { get; set; } = new DateTime(2010, 1, 1, 11, 1, 1);
		

	}
}
