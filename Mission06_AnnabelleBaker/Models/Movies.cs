using System.ComponentModel.DataAnnotations;

namespace Mission06_AnnabelleBaker.Models
{
    public class Movies
    {
            [Key]
            
            public int MovieID { get; set; } // same as building those getters and setters as before, PRIMARY KEY
            [Required]
            public required string Category { get; set; } // get category of movie
            [Required]
            public required string Title { get; set; } // title of movie
            [Required]  
            public required int Year { get; set; } // get year
            [Required]
            public required string Director { get; set; } // get director name
            [Required]
            public required string Rating { get; set; }  // get rating
            public bool? Edited { get; set; } // may not like that this is a bool but it 

            public string? LentTo { get; set; } // get notes
            public string? Notes { get; set; } // get notes
    }

}