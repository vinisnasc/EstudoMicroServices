using GeekShopping.CartAPI.Data.ValueObjects;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartVO> FindCartByUserId(string userId);
        Task<CartVO> SaveOrUpdateCart(CartVO cart);
        Task<bool> RemoveFromCart(long cartDetailsId);
        Task<bool> ApplyCupom(string userId, string cuponCode);
        Task<bool> RemoveCupom(string userId);
        Task<bool> ClearCart(string userId);
    }
}
