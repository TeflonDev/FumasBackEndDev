using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class LpoD
    {
        [Key]
        public int ldid { get; set; }
        public string no { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string descr { get; set; } = string.Empty;
        public string loc { get; set; } = string.Empty;
        public string pu { get; set; } = string.Empty;
        public decimal qty { get; set; } = 1;
        public decimal uprice { get; set; } = 0;
        public decimal total { get; set; } = 0;
        public int qty1 { get; set; } = 0;
        public decimal qtyd { get; set; } = 0;
        public string sname { get; set; } = string.Empty;
        public string job_no { get; set; } = string.Empty;
        public string remark_s { get; set; } = string.Empty;
        public decimal discount { get; set; } = 0;
        public decimal vat { get; set; } = 0;
        public string inclusive { get; set; } = "YES";
        public string taxable { get; set; } = "YES";
        public decimal weight { get; set; } = 0;
        public string type { get; set; } = "Stocks";
        public string costcenter { get; set; } = string.Empty;
        public string reqno { get; set; } = string.Empty;
        public string regno { get; set; } = string.Empty;
        public string trailerno { get; set; } = string.Empty;
        public string driver { get; set; } = string.Empty;
        public decimal discper { get; set; } = 0;
        public string taxcode { get; set; } = "DEFAULT";
    }
}