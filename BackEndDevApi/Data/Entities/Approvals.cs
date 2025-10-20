using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Approvals
    {
        [Key]
        public int id { get; set; }
        public string doc_type { get; set; } = string.Empty;
        public string doc_no { get; set; } = string.Empty;
        public int requester_id { get; set; } = 0;
        public int approver_id { get; set; } = 0;
        public string status { get; set; } = string.Empty;
        public string comments { get; set; } = string.Empty;
        public DateTime? date_requested { get; set; }
        public DateTime? date_approved { get; set; }
        public int del { get; set; } = 0;
    }
}