using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Reportsfields
    {
        [Key]
        public int id { get; set; }
        public int table_id { get; set; } = 0;
        public string field_name { get; set; } = string.Empty;
        public string display_name { get; set; } = string.Empty;
        public string data_type { get; set; } = string.Empty;
        public string format { get; set; } = string.Empty;
        public int is_visible { get; set; } = 1;
        public int sort_order { get; set; } = 0;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
    }
}