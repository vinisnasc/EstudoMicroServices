using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface ICartService
    {
        Task<CartViewModel> FindCartByUserId(string userId, string token);
        Task<CartViewModel> AddItemToCart(CartViewModel model, string token);
        Task<CartViewModel> UpdateCart(CartViewModel model, string token);
        Task<bool> RemoveFromCart(long cartId, string token);

        Task<bool> ApplyCoupon(CartViewModel model, string couponcode, string token);
        Task<bool> RemoveCoupon(string userId, string token);
        Task<bool> ClearCart(string userId, string token);

        Task<CartViewModel> CheckOut(CartHeaderViewModel model, string token);
    }
}
