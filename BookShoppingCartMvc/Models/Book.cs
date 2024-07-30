using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvc.Models
{
   
    [Table("Book")]
    public class Book
    {   
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public String? BookName { get; set; }
        [Required]
        [MaxLength(40)]
        public String? AuthorName { get; set; }

        public String? Image { get; set; }

        public double Price { get; set; }


        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }

        [NotMapped]
        public String GenreName { get; set; }

    }
}
