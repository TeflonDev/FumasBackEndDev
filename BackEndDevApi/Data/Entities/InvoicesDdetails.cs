using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class InvoicesDdetails
    {
        [Key]
        public int idid { get; set; }
        public string invno { get; set; } = string.Empty;
        public string type { get; set; } = string.Empty;
        public decimal amount { get; set; } = 0;
        public string code { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public decimal qty { get; set; } = 0;
        public decimal unitprice { get; set; } = 1;
        public string order_no { get; set; } = string.Empty;
        public string descriptions { get; set; } = string.Empty;
        public string details { get; set; } = string.Empty;
        public decimal vat { get; set; } = 0;
        public string inclusive { get; set; } = string.Empty;
        public string taxable { get; set; } = string.Empty;
        public decimal discount { get; set; } = 0;
        public string pu { get; set; } = "UNITS";
        public decimal cogs { get; set; } = 0;
        public string dno { get; set; } = string.Empty;
        public DateTime ddate { get; set; } = new DateTime(2010, 1, 1, 1, 1, 1);
        public string branch { get; set; } = "NONE";
        public decimal com { get; set; } = 0;
        public string sales_ref { get; set; } = string.Empty;
        public string sales_name { get; set; } = string.Empty;
        public decimal amount_paid { get; set; } = 0;
        public int raw_m { get; set; } = 1;
        public int car { get; set; } = 0;
        public string cname { get; set; } = string.Empty;
        public decimal discper { get; set; } = 0;
        public string scateg { get; set; } = "x";
        public string serial { get; set; } = string.Empty;
        public decimal bfeetqty1 { get; set; } = 1;
        public decimal bfeetqty2 { get; set; } = 1;
        public int ubfeet { get; set; } = 0;
        public string costcenter { get; set; } = string.Empty;
        public string flightlogno { get; set; } = string.Empty;
        public decimal hrs { get; set; } = 0;
        public string batchno { get; set; } = string.Empty;
        public string serialno { get; set; } = string.Empty;
        public string location { get; set; } = string.Empty;
        public int cbonus { get; set; } = 0;
        public int qtyd { get; set; } = 0;
        public string expdate { get; set; } = string.Empty;
        public decimal percent2 { get; set; } = 0;
        public int c_disc { get; set; } = 1;
        public int set_aside { get; set; } = 0;
        public int hasbooking { get; set; } = 0;
        public string bookingno { get; set; } = string.Empty;
        public string taxcode { get; set; } = "DEFAULT";
        public int dbfeet { get; set; } = 0;
        public string hscode_ { get; set; } = string.Empty;
        public string clientcode_ { get; set; } = string.Empty;
        public decimal ubfeetqty2 { get; set; } = 0;
    }
}