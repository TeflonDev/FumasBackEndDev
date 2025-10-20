using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Inventories
    {
        [Key]
        public int id { get; set; }
        public string item_code { get; set; } = string.Empty;
        public string item_name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public int categ_id { get; set; } = 0;
        public int subcateg_id { get; set; } = 0;
        public string unit { get; set; } = string.Empty;
        public decimal cost { get; set; } = 0;
        public decimal price { get; set; } = 0;
        public decimal qty { get; set; } = 0;
        public decimal min_qty { get; set; } = 0;
        public decimal max_qty { get; set; } = 0;
        public string status { get; set; } = string.Empty;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
    }
}