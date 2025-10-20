using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Stocktakes
    {
        [Key]
        public int id { get; set; }
        public int item_id { get; set; } = 0;
        public decimal stocknow { get; set; } = 0;
        public decimal newstock { get; set; } = 0;
        public decimal variance { get; set; } = 0;
        public string details { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
        public DateTime? date_closed { get; set; }
    }
}