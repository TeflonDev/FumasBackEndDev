using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Lpo
	{
		[Key]
		public int lid { get; set; }
		
		public string no { get; set; } = string.Empty;
		public string scode { get; set; } = string.Empty;
		public string sname { get; set; } = string.Empty;
		public DateTime ldate { get; set; } = new DateTime(2001, 1, 1);
		public DateTime ddate { get; set; } = new DateTime(2001, 1, 1);
		public string loc { get; set; } = string.Empty;
		public string remarks { get; set; } = string.Empty;
		public int posted { get; set; } = 0;
		public string screate { get; set; } = string.Empty;
		public DateTime dcreate { get; set; } = new DateTime(2001, 1, 1);
		public string spost { get; set; } = string.Empty;
		public DateTime dpost { get; set; } = new DateTime(2001, 1, 1);
		public int st { get; set; } = 0;
		public string tno { get; set; } = string.Empty;
		public string vote { get; set; } = string.Empty;
		public string user { get; set; } = string.Empty;
		public string accounts { get; set; } = string.Empty;
		public string requistion { get; set; } = string.Empty;
		public DateTime vdate { get; set; } = new DateTime(2001, 1, 1);
		public DateTime vddate { get; set; } = new DateTime(2001, 1, 1);
		public string period { get; set; } = string.Empty;
		public decimal vat { get; set; } = 0.0000m;
		public string vatable { get; set; } = string.Empty;
		public decimal totalvalue { get; set; } = 0.0000m;
		public decimal others { get; set; } = 0.0000m;
		public string taxinc { get; set; } = string.Empty;
		public string service { get; set; } = string.Empty;
		public string district { get; set; } = string.Empty;
		public string reason { get; set; } = string.Empty;
		public int printed { get; set; } = 0;
		public string printedby { get; set; } = string.Empty;
		public DateTime printeddate { get; set; } = new DateTime(2001, 1, 1);
		public string reprintedby { get; set; } = string.Empty;
		public DateTime reprinteddate { get; set; } = new DateTime(2001, 1, 1);
		public string lpocategory { get; set; } = string.Empty;
		public string currency { get; set; } = string.Empty;
		public string pmode { get; set; } = string.Empty;
		public decimal exclvat { get; set; } = 0.00m;
		public decimal disc { get; set; } = 0.00m;
		public int invoiced { get; set; } = 0;
		public string profitc { get; set; } = "x";
		public string dcurrency_s { get; set; } = "KES";
		public string cperiod { get; set; } = string.Empty;
		public decimal rate { get; set; } = 1.00000m;
		public int cinternal { get; set; } = 0;
		public string defaultaddress { get; set; } = string.Empty;
		public int two_level { get; set; } = 0;
		public int posted2 { get; set; } = 0;
		public string spost2 { get; set; } = string.Empty;
		public DateTime dpost2 { get; set; } = new DateTime(2022, 7, 12);
		public byte[] approval2 { get; set; } = new byte[0];
		public byte[] approval1 { get; set; } = new byte[0];
		public int approved { get; set; } = 0;
		public string branchcode { get; set; } = string.Empty;
	}
}