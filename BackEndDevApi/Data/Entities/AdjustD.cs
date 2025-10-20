using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class AdjustD
    {
        [Key]
        public int adid { get; set; }
        public string no { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string descr { get; set; } = string.Empty;
        public string loc { get; set; } = string.Empty;
        public string pu { get; set; } = string.Empty;
        public string ttype { get; set; } = "Decrease";
        public decimal qty { get; set; } = 0;
        public decimal price { get; set; } = 0;
        public decimal total { get; set; } = 0;
        public decimal qty1 { get; set; } = 0;
        public string serialno { get; set; } = string.Empty;
        public string batchno { get; set; } = string.Empty;
        public DateTime expdate { get; set; } = new DateTime(2050, 1, 1);
    }
}