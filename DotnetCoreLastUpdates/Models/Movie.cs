using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCoreLastUpdates.Models
{
    public class Movie //With Notations...
    {
        [Key] public Guid Id { get; set; }

        [Required(ErrorMessage = "Title is necessary")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "The title needs to have min 3 and max 100")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "ReleaseDate is necessary")]
        [DataType(DataType.DateTime, ErrorMessage = "ReleaseDate with invalid format")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00c0-\u00FF""'\w-]*$", ErrorMessage = "Invalid Category")]
        [StringLength(30, ErrorMessage = "Max 30")]
        public string Category { get; set; }

        [Range(1, 1000, ErrorMessage = "The price is between 1 ~ 1000")]
        [Required(ErrorMessage = "Price is necessary")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Rating is necessary")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Value between 0 ~ 5")]
        public int Rating { get; set; }
    }
}