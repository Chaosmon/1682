using BookMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly BookContext _context;

        public CartController(BookContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // TODO: Logic để lấy thông tin giỏ hàng
            // Ví dụ: Lấy giỏ hàng từ cơ sở dữ liệu
            var cart = _context.Carts.FirstOrDefault(); // Đây chỉ là ví dụ, bạn cần thay thế nó bằng logic thực tế của bạn

            // Truyền giỏ hàng đến view
            return View(cart);
        }
    }
}
