namespace BookShoppingCartMvc.Models.Repositories
{
    public interface ICartRepository
    {
        Task<ShoppingCart> GetUserCart();
        Task<int> AddItem(int bookId, int qty);
        Task<int> RemoveItem(int bookId);

        Task<int> GetCartItemCount(string userId = "");


        Task<ShoppingCart> GetCart(string userId);
    }

}