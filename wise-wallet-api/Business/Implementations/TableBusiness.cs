using wise_wallet_api.Business.Interfaces;
using wise_wallet_api.Domains;
using wise_wallet_api.Repository.Interfaces;

namespace wise_wallet_api.Business.Implementations
{
    public class TableBusiness : ITableBusiness
    {
        private readonly ITableRepository _repository;

        public TableBusiness(ITableRepository repository)
        {
            _repository = repository;
        }

        public Table Create(Table table)
        {
            return _repository.Create(table);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Table> GetAll()
        {
            return _repository.GetAll();
        }

        public Table GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
