using wise_wallet_api.Data;
using wise_wallet_api.Domains;
using wise_wallet_api.Repository.Interfaces;

namespace wise_wallet_api.Repository.Implementations
{
    public class CardRepository : ICardRepository
    {
        private readonly DataContext _context;
        public CardRepository(DataContext context)
        {
            _context = context;
        }

        public Card CreateCard(Card card)
        {
            try
            {
                _context.Cards.Add(card);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex.GetBaseException();
            }
            return card;
        }

        public void Delete(int id)
        {
            var card = _context.Cards.Find(id);
            if (card != null)
            {
                try
                {
                    _context.Cards.Remove(card);
                    _context.SaveChanges();

                }
                catch (Exception ex)
                {

                    throw ex.GetBaseException();
                }
            }
        }

        public List<Card> GetAll()
        {
            return _context.Cards.ToList();
        }

        public Card GetById(int id)
        {
            var card = _context.Cards.Find(id);
            return card;
        }
    }
}
