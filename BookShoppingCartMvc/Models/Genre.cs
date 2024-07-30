using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvc.Models
{

    [Table("Genre")]
    public class Genre
    {


        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public String? GenreName { get; set; }
        public List<Book> Books { get; set; }

    }
}
