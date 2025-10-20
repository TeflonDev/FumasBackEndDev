using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Budgetitems
    {
        [Key]
        public int id { get; set; }
        public int budget_id { get; set; } = 0;
        public string item_code { get; set; } = string.Empty;
        public string item_name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public decimal budgeted_amount { get; set; } = 0;
        public decimal actual_amount { get; set; } = 0;
        public decimal variance { get; set; } = 0;
        public string status { get; set; } = string.Empty;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
    }
}