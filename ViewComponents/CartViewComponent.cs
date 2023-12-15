using HShop.Helpers;
using HShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HShop.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>
                (MySettings.Cart_Key) ?? new List<CartItem>();
            return View("CartPanel", new CartModel
            {
                Quantity = cart.Sum(p => p.SoLuong),
                Total = cart.Sum(p => p.ThanhTien),
            });
        }
    }
}
