using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using wise_wallet_api.Data;
using wise_wallet_api.Domains;
using wise_wallet_api.Repository.Interfaces;

namespace wise_wallet_api.Repository.Implementations
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext _context;

        public ItemRepository(DataContext context)
        {
            _context = context;
        }

        public Item AddItem(Item item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex.GetBaseException();
            }
            return item;
        }

        public List<Item> GetItens()
        {
            return _context.Itens.ToList();
        }

        public List<Item> GetItensByCardId(int id)
        {
            var query = $"SELECT * FROM itens WHERE CardId = {id}";
            var itens = _context.Itens.FromSqlRaw(query).ToList();
            return itens;
        }

        public void RemoveItem(int id)
        {
            var result = _context.Itens.Find(id);
            if (result != null)
            {
                try
                {
                    _context.Itens.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex.GetBaseException();
                }
            }
        }
    }
}
