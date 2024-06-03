using wise_wallet_api.Domains;

namespace wise_wallet_api.Repository.Interfaces
{
    public interface ITableRepository
    {
        List<Table> GetAll();
        Table GetById(int id);
        Table Create(Table table);
        void Delete(int id);
    }
}
