using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
	public class Clients
	{
		[Key]
		public int cid { get; set; }
		
		public string code { get; set; } = string.Empty;
		public string names { get; set; } = string.Empty;
		public string tel1 { get; set; } = string.Empty;
		public string tel2 { get; set; } = string.Empty;
		public string p_address { get; set; } = string.Empty;
		public string phy_address { get; set; } = string.Empty;
		public string email { get; set; } = string.Empty;
		public string dept1 { get; set; } = string.Empty;
		public string dept2 { get; set; } = string.Empty;
		public string dept3 { get; set; } = string.Empty;
		public string dept4 { get; set; } = string.Empty;
		public string passport { get; set; } = string.Empty;
		public string dl { get; set; } = string.Empty;
		public string cellphone { get; set; } = string.Empty;
		public int w_limit { get; set; } = 0;
		public int c_limit { get; set; } = 0;
		public int active { get; set; } = 1;
		public int cr { get; set; } = 0;
		public int cm { get; set; } = 0;
		public string country { get; set; } = string.Empty;
		public string cate { get; set; } = string.Empty;
		public string vatno { get; set; } = string.Empty;
		public string pinno { get; set; } = string.Empty;
		public int use_limit { get; set; } = 0;
		public string route { get; set; } = "NONE";
		public string paymode { get; set; } = "NONE";
		public DateTime dob { get; set; } = new DateTime(2010, 1, 1);
		public string insurance { get; set; } = string.Empty;
		public string employer { get; set; } = string.Empty;
		public string account_type { get; set; } = string.Empty;
		public string mob { get; set; } = string.Empty;
		public string nationality { get; set; } = string.Empty;
		public string doctor { get; set; } = string.Empty;
		public string idno { get; set; } = string.Empty;
		public string referral { get; set; } = string.Empty;
		public string nokname { get; set; } = string.Empty;
		public string noktel { get; set; } = string.Empty;
		public string nokmob { get; set; } = string.Empty;
		public string nokaddress { get; set; } = string.Empty;
		public string noktown { get; set; } = string.Empty;
		public string nokemail { get; set; } = string.Empty;
		public string nokfax { get; set; } = string.Empty;
		public string pricelist { get; set; } = "NONE";
		public int TERMS { get; set; } = 14;
		public string shipto { get; set; } = string.Empty;
		public string area { get; set; } = string.Empty;
		public string sales_name { get; set; } = string.Empty;
		public string payaccount { get; set; } = string.Empty;
		public string pack_act { get; set; } = string.Empty;
		public int allowzero { get; set; } = 0;
		public string dcurrency_s { get; set; } = "US DOLLAR";
		public int cfuel { get; set; } = 0;
		public int chours { get; set; } = 0;
		public string cregion { get; set; } = "JUBA";
		public string glcategory { get; set; } = "NONE";
		public string orderloc { get; set; } = string.Empty;
		public string maidenname { get; set; } = string.Empty;
		public string idserial { get; set; } = string.Empty;
		public string sales_ref { get; set; } = string.Empty;
		public string comlist { get; set; } = "NONE";
		public string discountlist { get; set; } = "NONE";
		public string countrycode { get; set; } = "+254";
		public string countryname { get; set; } = "Kenya";
		public int individual { get; set; } = 0;
		public int rindividual { get; set; } = 0;
		public int cregistration { get; set; } = 0;
		public int cpin { get; set; } = 0;
		public int ccid { get; set; } = 0;
		public int cbusiness { get; set; } = 0;
		public int cpassport { get; set; } = 0;
		public string customer_exid { get; set; } = string.Empty;
		public string encrypt_ { get; set; } = string.Empty;
		public string encrypt2_ { get; set; } = string.Empty;
		public DateTime last_updated { get; set; } = new DateTime(2010, 1, 1, 8, 1, 1);
		public DateTime dcreate { get; set; } = new DateTime(2025, 1, 1);
		public int cautodonotallocate { get; set; } = 0;
		public string paybillaccount { get; set; } = string.Empty;
		public string comlist2 { get; set; } = "NONE";
		public string encryt2_ { get; set; } = string.Empty;
		public string disc { get; set; } = string.Empty;
	}
}