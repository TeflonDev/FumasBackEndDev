using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Expenses
    {
        [Key]
        public int id { get; set; }
        public string doc_no { get; set; } = string.Empty;
        public string doc_date { get; set; } = string.Empty;
        public string expense_type { get; set; } = string.Empty;
        public decimal amount { get; set; } = 0;
        public string description { get; set; } = string.Empty;
        public string payment_method { get; set; } = string.Empty;
        public string reference { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public int staff_id { get; set; } = 0;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
    }
}