using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreSystem.Models
{
    [Table("Writers")]  // Maps this class to a table named "Writers" instead of "Authors"
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Country { get; set; }
    }
}
