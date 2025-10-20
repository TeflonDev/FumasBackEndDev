using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Budget
    {
        [Key]
        public int id { get; set; }
        public string doc_no { get; set; } = string.Empty;
        public string doc_date { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string period_from { get; set; } = string.Empty;
        public string period_to { get; set; } = string.Empty;
        public decimal total_amount { get; set; } = 0;
        public string status { get; set; } = string.Empty;
        public int staff_id { get; set; } = 0;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
    }
}