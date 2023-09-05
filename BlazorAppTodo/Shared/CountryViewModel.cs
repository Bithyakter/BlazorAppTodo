using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlazorAppTodo.Shared
{
   public class CountryViewModel
   {
      public int Id { get; set; }

      [Required]
      [Display(Name = "Country Name")]
      public string CountryName { get; set; }

      [Required]
      [Display(Name = "ISO Alpha-2")]
      public string ISOCodeAlpha2 { get; set; }

      [Required]
      [Display(Name = "Country Code")]
      public string CountryCode { get; set; }     
   }
}
