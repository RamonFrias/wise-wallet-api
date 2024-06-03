using wise_wallet_api.Domains;

namespace wise_wallet_api.Business.Interfaces
{
    public interface ICardBusiness
    {
        List<Card> GetAll();
        Card GetById(int id);
        Card CreateCard(Card card);
        void Delete(int id);
    }
}
