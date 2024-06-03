using wise_wallet_api.Domains;

namespace wise_wallet_api.Business.Interfaces
{
    public interface ITableBusiness
    {
        List<Table> GetAll();
        Table GetById(int id);
        Table Create(Table table);
        void Delete(int id);
    }
}
