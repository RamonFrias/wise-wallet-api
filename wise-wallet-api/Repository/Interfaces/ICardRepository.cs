using wise_wallet_api.Domains;

namespace wise_wallet_api.Repository.Interfaces
{
    public interface ICardRepository
    {
        List<Card> GetAll();
        Card GetById(int id);
        Card CreateCard(Card card);
        void Delete(int id);
    }
}
