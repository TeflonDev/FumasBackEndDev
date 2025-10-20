using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class JournalTransactions
    {
        [Key]
        public int jtid { get; set; }
        public string code { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string remarks { get; set; } = string.Empty;
        public decimal amount { get; set; } = 0;
        public string cheque_no { get; set; } = "None";
        public decimal rtotal { get; set; } = 0;
        public DateTime jtdate { get; set; } = new DateTime(2001, 1, 1);
        public string trancode { get; set; } = string.Empty;
        public string trantype { get; set; } = string.Empty;
        public string staff { get; set; } = string.Empty;
        public DateTime staffdate { get; set; } = new DateTime(2001, 1, 1);
        public string transign { get; set; } = string.Empty;
        public string branchcode { get; set; } = string.Empty;
        public string rec { get; set; } = string.Empty;
        public decimal r_amt { get; set; } = 0;
        public decimal r_var { get; set; } = 0;
        public string r_s { get; set; } = string.Empty;
        public DateTime r_d { get; set; } = new DateTime(2001, 1, 1);
        public string r_desc { get; set; } = string.Empty;
        public string r_st { get; set; } = string.Empty;
        public string r_rr { get; set; } = string.Empty;
        public string source { get; set; } = string.Empty;
        public decimal prd_yr { get; set; } = 0;
        public string cost_center { get; set; } = string.Empty;
        public string profitc { get; set; } = "x";
        public int jstatus { get; set; } = 1;
        public string dcurrency_s { get; set; } = "KES";
        public string cperiod { get; set; } = string.Empty;
        public decimal rate { get; set; } = 1;
        public decimal amount_paid { get; set; } = 0;
        public string r_bankdate { get; set; } = string.Empty;
    }
}