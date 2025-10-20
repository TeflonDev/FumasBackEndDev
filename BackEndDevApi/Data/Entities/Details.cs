using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Details
    {
        [Key]
        public int id { get; set; }
        public string doc_no { get; set; } = string.Empty;
        public string doc_type { get; set; } = string.Empty;
        public int item_id { get; set; } = 0;
        public decimal qty { get; set; } = 0;
        public decimal price { get; set; } = 0;
        public decimal discount { get; set; } = 0;
        public decimal amount { get; set; } = 0;
        public decimal tax { get; set; } = 0;
        public decimal netamount { get; set; } = 0;
        public string status { get; set; } = string.Empty;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
    }
}