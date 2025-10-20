using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class GrnD
    {
        [Key]
        public int gdid { get; set; }
        public string no { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string descr { get; set; } = string.Empty;
        public string loc { get; set; } = string.Empty;
        public string pu { get; set; } = string.Empty;
        public decimal qty { get; set; } = 0;
        public decimal uprice { get; set; } = 0;
        public string screensize { get; set; } = string.Empty;
        public string soilname { get; set; } = string.Empty;
        public string altitude { get; set; } = string.Empty;
        public string region { get; set; } = string.Empty;
        public string moisture { get; set; } = string.Empty;
        public string grading { get; set; } = string.Empty;
        public string certification { get; set; } = string.Empty;
        public string processingdetails { get; set; } = string.Empty;
        public DateTime seasonfrom { get; set; } = new DateTime(2000, 1, 1);
        public DateTime seasonto { get; set; } = new DateTime(2000, 1, 1);
        public decimal total { get; set; } = 0;
        public decimal qty1 { get; set; } = 0;
        public decimal qtyd { get; set; } = 0;
        public string acct { get; set; } = string.Empty;
        public string acct_name { get; set; } = string.Empty;
        public string batchno { get; set; } = string.Empty;
        public decimal freight { get; set; } = 0;
        public decimal clearing { get; set; } = 0;
        public DateTime expirydate { get; set; } = new DateTime(2001, 1, 1);
        public decimal discount { get; set; } = 0;
        public string taxable { get; set; } = "NO";
        public decimal vat { get; set; } = 0;
        public string inclusive { get; set; } = "YES";
        public string serialno { get; set; } = string.Empty;
        public DateTime expdate { get; set; } = new DateTime(2050, 1, 1);
        public decimal basicprice { get; set; } = 0;
        public decimal freightcost { get; set; } = 0;
        public decimal clearingcost { get; set; } = 0;
        public decimal grnqty { get; set; } = 0;
        public decimal discper { get; set; } = 0;
        public int cbonus { get; set; } = 0;
        public string capacity { get; set; } = "0";
        public decimal unit { get; set; } = 0;
        public decimal unittotal { get; set; } = 0;
        public string prunits2 { get; set; } = string.Empty;
        public decimal unitstd { get; set; } = 0;
        public int c_disc { get; set; } = 1;
    }
}