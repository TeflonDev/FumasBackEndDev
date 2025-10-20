using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class SysSettings
    {
        [Key]
        public int settingid { get; set; }
        public string setting_key { get; set; } = string.Empty;
        public string setting_value { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string category { get; set; } = string.Empty;
        public int active { get; set; } = 1;
        public string data_type { get; set; } = "string";
        public string createdby { get; set; } = string.Empty;
        public DateTime createddate { get; set; } = new DateTime(2001, 1, 1);
        public string modifiedby { get; set; } = string.Empty;
        public DateTime modifieddate { get; set; } = new DateTime(2001, 1, 1);
        public string validation_rule { get; set; } = string.Empty;
        public string default_value { get; set; } = string.Empty;
        public int requires_restart { get; set; } = 0;
        public string allowed_values { get; set; } = string.Empty;
        public int sort_order { get; set; } = 0;
        public int is_encrypted { get; set; } = 0;
        public string module { get; set; } = string.Empty;
    }
}