using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class SysForms
    {
        [Key]
        public int formid { get; set; }
        public string formname { get; set; } = string.Empty;
        public string formcaption { get; set; } = string.Empty;
        public string module { get; set; } = string.Empty;
        public int active { get; set; } = 1;
        public string description { get; set; } = string.Empty;
        public string menu_path { get; set; } = string.Empty;
        public string icon { get; set; } = string.Empty;
        public int sort_order { get; set; } = 0;
        public int requires_permission { get; set; } = 0;
        public string permission_code { get; set; } = string.Empty;
        public string createdby { get; set; } = string.Empty;
        public DateTime createddate { get; set; } = new DateTime(2001, 1, 1);
        public string modifiedby { get; set; } = string.Empty;
        public DateTime modifieddate { get; set; } = new DateTime(2001, 1, 1);
        public string shortcut_key { get; set; } = string.Empty;
        public string url { get; set; } = string.Empty;
        public int is_visible { get; set; } = 1;
    }
}