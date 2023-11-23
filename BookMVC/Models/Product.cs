using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMVC.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(250)]
        [Required]
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Mô tả sản phẩm")]
        public string? Description { get; set; }
        [DataType(DataType.Currency), Range(1, double.MaxValue)]
        [DisplayName("Giá")]
        public decimal Price { get; set; } = 0;
        [DisplayName("Tác Giả")]
        public string? Author { get; set; }
        public DateTime PublishDate { get; set; }
        //public string ISBN { get; set; }
        public int CategoryId { get; set; }
        public bool Status { get; set; }
        public virtual Category Category { get; set; }
    }
}
