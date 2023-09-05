using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppTodo.Server.Models
{
    [Table("Country", Schema ="dbo")]
    public class Country
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required] 
        public string CountryName { get; set; }
        
        [Required] 
        public string ISOCodeAlpha2 { get; set; }
        
        [Required] 
        public string CountryCode { get;set; }
    }
}
