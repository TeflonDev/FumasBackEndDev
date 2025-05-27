using System.ComponentModel.DataAnnotations;

namespace BackEndDevApi.Data.Entities
{
    public class Pu
    {  
       
        
        [Key]
        public int? id { get; set; }
		public string? code { get; set; }
		public string? descr { get; set; }       
        public decimal? factor { get; set; }
        public string? categ { get; set; }
    }

}
