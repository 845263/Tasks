using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplicationNetCore.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Bid { get; set; }
        [Display(Name ="Book Title")]
        [Required]
        public string Btitle { get; set; }
        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Required]
        public string Authorname { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Display(Name ="Release Date")]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
    }
}
