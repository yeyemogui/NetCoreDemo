using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength =3)]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1/1/1966","1/1/2020")]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string Genre { get; set; }
        [Range(0, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
