using wise_wallet_api.Domains;

namespace wise_wallet_api.Repository.Interfaces
{
    public interface IItemBusiness
    {
        List<Item> GetItens();
        List<Item> GetItensByCardId(int id);
        Item AddItem(Item item);
        void RemoveItem(int id);
    }
}
