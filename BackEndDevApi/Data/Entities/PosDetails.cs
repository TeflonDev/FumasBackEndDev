using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class PosDetails
    {
        [Key]
        public int posdid { get; set; }
        public string receiptno { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public decimal qty { get; set; } = 0;
        public decimal price { get; set; } = 0;
        public decimal total { get; set; } = 0;
        public decimal vat { get; set; } = 0;
        public string location { get; set; } = string.Empty;
        public bool item { get; set; } = false;
        public string ref_ { get; set; } = string.Empty;
        public string punit { get; set; } = string.Empty;
        public decimal unitcost { get; set; } = 0;
        public decimal buy_cost { get; set; } = 0;
        public string nunit { get; set; } = string.Empty;
        public decimal disc { get; set; } = 0;
        public string inclusive { get; set; } = string.Empty;
        public string taxable { get; set; } = string.Empty;
        public string type { get; set; } = "Stocks";
        public int posted { get; set; } = 0;
        public string icateg { get; set; } = "x";
        public decimal hlevy { get; set; } = 0;
        public string transign { get; set; } = "+";
        public string serialno { get; set; } = string.Empty;
        public string batchno { get; set; } = string.Empty;
        public decimal bfeetqty1 { get; set; } = 1;
        public decimal bfeetqty2 { get; set; } = 1;
        public int ubfeet { get; set; } = 0;
        public string dbfeet { get; set; } = string.Empty;
        public int taway { get; set; } = 0;
        public string comments { get; set; } = string.Empty;
        public int bprinted { get; set; } = 0;
        public int mid { get; set; } = 0;
        public string main_multiple { get; set; } = string.Empty;
        public int cbonus { get; set; } = 0;
        public DateTime expdate { get; set; } = new DateTime(2050, 1, 1);
        public string costcenter { get; set; } = string.Empty;
        public string hscode_ { get; set; } = string.Empty;
        public int dispatchstatus { get; set; } = 0;
        public int confirmedqtty { get; set; } = 0;
        public int confirmedqty { get; set; } = 0;
        public string invorderno { get; set; } = string.Empty;
    }
}