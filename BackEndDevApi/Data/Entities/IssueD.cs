using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class IssueD
    {
        [Key]
        public int idid { get; set; }
        public string no { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string descr { get; set; } = string.Empty;
        public string loc { get; set; } = string.Empty;
        public string pu { get; set; } = string.Empty;
        public decimal qty { get; set; } = 0;
        public decimal uprice { get; set; } = 0;
        public decimal total { get; set; } = 0;
        public decimal qty1 { get; set; } = 0;
        public int posted { get; set; } = 0;
        public string iserial { get; set; } = string.Empty;
        public string batchno { get; set; } = string.Empty;
        public decimal sellingprice { get; set; } = 0;
        public string aircraft { get; set; } = string.Empty;
        public DateTime expdate { get; set; } = new DateTime(2050, 1, 1);
        public int speedometer { get; set; } = 0;
        public string journeylog { get; set; } = string.Empty;
        public string route { get; set; } = string.Empty;
        public decimal distance { get; set; } = 0;
        public decimal avrkms { get; set; } = 0;
        public decimal balbf { get; set; } = 0;
        public decimal pumpstart { get; set; } = 0;
        public decimal pumpend { get; set; } = 0;
        public decimal pumpsum { get; set; } = 0;
        public decimal totallitres { get; set; } = 0;
        public string ldid { get; set; } = string.Empty;
        public decimal unit { get; set; } = 0;
        public decimal unittotal { get; set; } = 0;
        public string prunits2 { get; set; } = string.Empty;
        public decimal unitstd { get; set; } = 0;
    }
}