using wise_wallet_api.Business.Interfaces;
using wise_wallet_api.Domains;
using wise_wallet_api.Repository.Interfaces;

namespace wise_wallet_api.Business.Implementations
{
    public class CardBusiness : ICardBusiness
    {
        private readonly ICardRepository _repository;
        public CardBusiness(ICardRepository repository) 
        {
            _repository = repository;
        }
        public Card CreateCard(Card card)
        {
            return _repository.CreateCard(card);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Card> GetAll()
        {
            return _repository.GetAll();
        }

        public Card GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
