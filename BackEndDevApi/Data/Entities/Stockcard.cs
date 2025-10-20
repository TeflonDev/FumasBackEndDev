using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Stockcard
    {
        [Key]
        public int id { get; set; }
        public int staff_id { get; set; } = 0;
        public string trn_type { get; set; } = string.Empty;
        public int doc_id { get; set; } = 0;
        public string doc_no { get; set; } = string.Empty;
        public string doc_date { get; set; } = string.Empty;
        public int item_id { get; set; } = 0;
        public decimal inqty { get; set; } = 0;
        public decimal outqty { get; set; } = 0;
        public decimal balqty { get; set; } = 0;
        public decimal inval { get; set; } = 0;
        public decimal outval { get; set; } = 0;
        public decimal balval { get; set; } = 0;
        public string details { get; set; } = string.Empty;
        public string flag { get; set; } = string.Empty;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
    }
}