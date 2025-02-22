using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Mission06_AnnabelleBaker.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; } // Primary key

        [Required]
        public string Category { get; set; } = string.Empty; // Required field

        [Required(ErrorMessage = "Please enter a valid movie title")]
        public string Title { get; set; } = string.Empty;

        [Required, Range(1888, 9999, ErrorMessage = "Please enter a valid year after 1888.")]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; } = string.Empty;

        [Required]
        public string Rating { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please indicate whether the movie should be edited.")]
        public bool Edited { get; set; } // No need for required since bool is non-nullable
        public bool CopiedToPlex { get; set; } // no need for required since bool is non-nullable
        public string? LentTo { get; set; } // Nullable field
        public string? Notes { get; set; } // Nullable field
    }

}
