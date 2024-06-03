using wise_wallet_api.Data;
using wise_wallet_api.Domains;
using wise_wallet_api.Repository.Interfaces;

namespace wise_wallet_api.Repository.Implementations
{
    public class TableRepository : ITableRepository
    {
        private readonly DataContext _context;

        public TableRepository(DataContext context)
        {
            _context = context;
        }

        public Table Create(Table table)
        {
            try
            {
                _context.Tables.Add(table);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
            return table;
        }

        public void Delete(int id)
        {
            var table = _context.Tables.Find(id);
            if(table != null)
            {
                try
                {
                    _context.Tables.Remove(table);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex.GetBaseException();
                }
            }
        }

        public List<Table> GetAll()
        {
            return _context.Tables.ToList();
        }

        public Table GetById(int id)
        {
            return _context.Tables.Find(id);
        }
    }
}
