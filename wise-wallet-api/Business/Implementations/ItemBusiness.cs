using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using wise_wallet_api.Data;
using wise_wallet_api.Domains;
using wise_wallet_api.Repository.Interfaces;

namespace wise_wallet_api.Repository.Implementations
{
    public class ItemBusiness : IItemBusiness
    {
        private readonly IItemRepository _repository;

        public ItemBusiness(IItemRepository repository)
        {
            _repository = repository;
        }

        public Item AddItem(Item item)
        {
            return _repository.AddItem(item);
        }

        public List<Item> GetItens()
        {
            return _repository.GetItens();
        }

        public List<Item> GetItensByCardId(int id)
        {
            return _repository.GetItensByCardId(id);
        }

        public void RemoveItem(int id)
        {
            _repository.RemoveItem(id);
        }
    }
}
