using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Nauto
    {
        [Key]
        public int id { get; set; }
        public string code { get; set; } = string.Empty;
        public string vatoutput { get; set; } = string.Empty;
        public string vatinput { get; set; } = string.Empty;
        public string inventory { get; set; } = string.Empty;
        public string revenue { get; set; } = string.Empty;
        public string cogs { get; set; } = string.Empty;
        public string debtorsacct { get; set; } = "DEBTORS_ACCT";
        public string discountrec { get; set; } = string.Empty;
        public string discountgiven { get; set; } = string.Empty;
        public string rlocation { get; set; } = string.Empty;
        public string olocation { get; set; } = string.Empty;
        public string plocation { get; set; } = string.Empty;
        public string rlocations { get; set; } = string.Empty;
        public int vat { get; set; } = 0;
        public int vatinclusive { get; set; } = 0;
        public int recordlimit { get; set; } = 0;
        public int orders { get; set; } = 0;
        public string porder { get; set; } = string.Empty;
        public int aorder { get; set; } = 0;
        public int grn { get; set; } = 0;
        public string pgrn { get; set; } = string.Empty;
        public int agrn { get; set; } = 0;
        public int crinvoice { get; set; } = 0;
        public string pcrinvoice { get; set; } = string.Empty;
        public int acrinvoice { get; set; } = 0;
        public int payments { get; set; } = 0;
        public string ppayments { get; set; } = string.Empty;
        public int apayments { get; set; } = 0;
        public string cashaccount { get; set; } = "CASH";
        public string creditorsacct { get; set; } = "CREDITORS_ACCT";
        public string prepayment_ac { get; set; } = "PREPAYMENT_ACCT";
        public string currency_s { get; set; } = "KES";
        public decimal profitmargin { get; set; } = 1;
        public int decimal_place { get; set; } = 2;
        public int decimal_place_amount { get; set; } = 2;
        public int price_override { get; set; } = 1;
        public string BillClearingAc { get; set; } = string.Empty;
    }
}