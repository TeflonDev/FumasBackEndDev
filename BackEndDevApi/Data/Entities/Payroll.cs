using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Payroll
    {
        [Key]
        public int id { get; set; }
        public string doc_no { get; set; } = string.Empty;
        public string pay_period { get; set; } = string.Empty;
        public int employee_id { get; set; } = 0;
        public decimal basic_salary { get; set; } = 0;
        public decimal allowances { get; set; } = 0;
        public decimal deductions { get; set; } = 0;
        public decimal overtime { get; set; } = 0;
        public decimal gross_pay { get; set; } = 0;
        public decimal tax { get; set; } = 0;
        public decimal net_pay { get; set; } = 0;
        public string status { get; set; } = string.Empty;
        public int del { get; set; } = 0;
        public DateTime? date_created { get; set; }
    }
}