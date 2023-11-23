using System.ComponentModel.DataAnnotations;

namespace BookMVC.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // Người dùng mà giỏ hàng này thuộc về
        //public ICollection<CartItem> Items { get; set; } // Danh sách các mục trong giỏ hàng
        public ICollection<CartDetail> CartDetails { get; set; } // Danh sách các chi tiết giỏ hàng
    }
}
