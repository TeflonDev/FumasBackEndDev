using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Pu
    {  
       
        
        [Key]
        public int? id { get; set; }
        public string? code { get; set; } = string.Empty;
		public string? descr { get; set; } = string.Empty;
		public decimal? factor { get; set; } = 1.00m;   
		public string? categ { get; set; } = string.Empty;  
    }

}
