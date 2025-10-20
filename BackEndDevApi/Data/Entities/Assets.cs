using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Assets
    {
        [Key]
        public int id { get; set; }
        public string asset_code { get; set; } = string.Empty;
        public string asset_name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string category { get; set; } = string.Empty;
        public decimal cost { get; set; } = 0;
        public decimal current_value { get; set; } = 0;
        public string purchase_date { get; set; } = string.Empty;
        public string location { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
    }
}