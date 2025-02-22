using System.ComponentModel.DataAnnotations;

namespace Mission06_AnnabelleBaker.Models
{
    // this is the code for the category table
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}


