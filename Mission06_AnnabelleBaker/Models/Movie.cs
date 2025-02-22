using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Mission06_AnnabelleBaker.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; } // Primary key

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; } // nullable foreign key

        public Category? Category { get; set; } // navigation property - that was the error I was getting

        [Required(ErrorMessage = "Please enter a valid movie title")]
        public string Title { get; set; }

        [Required, Range(1888, 9999, ErrorMessage = "Please enter a valid year after 1888.")]
        public int Year { get; set; }

        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required(ErrorMessage = "Please indicate whether the movie should be edited.")]
        public bool Edited { get; set; } // No need for required since bool is non-nullable
        
        [Required(ErrorMessage = "Please indicate whether the movie was copied to plex.")]
        public bool CopiedToPlex { get; set; } // no need for required since bool is non-nullable
        public string? LentTo { get; set; } // Nullable field
        
        [MaxLength(25)]
        public string? Notes { get; set; } // Nullable field
    }

}
