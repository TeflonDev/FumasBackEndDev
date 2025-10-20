using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Autosettings
	{
		[Key]
		public int id { get; set; }
		
		public int Jdir { get; set; } = 0;
		public int Fdir { get; set; } = 0;
		public int Mdir { get; set; } = 0;
		public int Adir { get; set; } = 0;
		public int Mydir { get; set; } = 0;
		public int Jndir { get; set; } = 0;
		public int Jldir { get; set; } = 0;
		public int Agdir { get; set; } = 0;
		public int Sdir { get; set; } = 0;
		public int Odir { get; set; } = 0;
		public int Ndir { get; set; } = 0;
		public int Ddir { get; set; } = 0;
		public int Jspd { get; set; } = 0;
		public int Fspd { get; set; } = 0;
		public int Mspd { get; set; } = 0;
		public int Aspd { get; set; } = 0;
		public int Myspd { get; set; } = 0;
		public int Jnspd { get; set; } = 0;
		public int Jlspd { get; set; } = 0;
		public int Agspd { get; set; } = 0;
		public int Sspd { get; set; } = 0;
		public int Ospd { get; set; } = 0;
		public int Nspd { get; set; } = 0;
		public int Dspd { get; set; } = 0;
		public decimal margin { get; set; } = 0.27m;
		public decimal fuel_cost { get; set; } = 1.15m;
		public string currency_s { get; set; } = string.Empty;
		public int quotation { get; set; } = 1;
		public string quotationp { get; set; } = string.Empty;
		public int quotationa { get; set; } = 1;
		public int flightlog { get; set; } = 1;
		public string flightlogp { get; set; } = string.Empty;
		public int flightloga { get; set; } = 1;
		public int manifest { get; set; } = 1;
		public string manifestp { get; set; } = string.Empty;
		public int manifesta { get; set; } = 1;
		public int tracking { get; set; } = 1;
		public string trackingp { get; set; } = string.Empty;
		public int trackinga { get; set; } = 1;
		public int ticketing { get; set; } = 1;
		public string ticketingp { get; set; } = string.Empty;
		public int ticketinga { get; set; } = 1;
		public int flightplan { get; set; } = 0;
		public string flightplanp { get; set; } = string.Empty;
		public int flightplana { get; set; } = 0;
		public int mflighttime { get; set; } = 105;
		public int mdutytime { get; set; } = 160;
		public int mflighttime_alert { get; set; } = 80;
		public int mdutytime_alert { get; set; } = 140;
		public int events { get; set; } = 1;
		public string eventsp { get; set; } = "Ev";
		public int eventsa { get; set; } = 1;
		public string firstemail { get; set; } = string.Empty;
		public string secondemail { get; set; } = string.Empty;
		public string thirdemail { get; set; } = string.Empty;
		public string fourthemail { get; set; } = string.Empty;
		public int assemblys { get; set; } = 1;
		public string assemblysp { get; set; } = string.Empty;
		public int assemblysa { get; set; } = 1;
		public int apu { get; set; } = 1;
		public string apup { get; set; } = "APU";
		public int apua { get; set; } = 1;
		public string cfirstemail { get; set; } = "waweru@futuresoft.co.ke";
		public string csecondemail { get; set; } = "james@futuresoft.co.ke";
		public int amp { get; set; } = 1;
		public string ampp { get; set; } = string.Empty;
		public int ampa { get; set; } = 1;
		public int sb { get; set; } = 1;
		public string sbp { get; set; } = string.Empty;
		public int sba { get; set; } = 1;
		public int ad { get; set; } = 1;
		public string adp { get; set; } = string.Empty;
		public int ada { get; set; } = 1;
		public int defect { get; set; } = 1;
		public string defectp { get; set; } = string.Empty;
		public int defecta { get; set; } = 1;
		public int task { get; set; } = 1;
		public string taskp { get; set; } = string.Empty;
		public int taska { get; set; } = 1;
		public int jobcard { get; set; } = 1;
		public string jobcardp { get; set; } = string.Empty;
		public int jobcarda { get; set; } = 1;
	}
}