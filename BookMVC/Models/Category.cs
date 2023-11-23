using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required, StringLength(30)]
        [DisplayName("Thể Loại")]
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
