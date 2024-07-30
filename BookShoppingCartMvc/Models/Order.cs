using System.ComponentModel.DataAnnotations;

namespace BookShoppingCartMvc.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public String? UserId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        [Required]
        public bool IsDeleted { get; set; }
        public int OrderStatusId { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }


    }
}
