using System.Reflection.Metadata.Ecma335;
using wise_wallet_api.Domains.Enums;

namespace wise_wallet_api.Domains
{
    public class Card
    {
        public int CardId { get; set; }
        public int CardNumber { get; set; }
        public Client ClientId { get; set; }
        public Table TableId { get; set; }
        public EStatus CardStatus { get; set; }
        public List<Item> Itens{ get; set; } = new List<Item>();

        public Card(int cardId, int cardNumber, Client clientId, Table tableId, EStatus cardStatus, List<Item> itens)
        {
            CardId = cardId;
            CardNumber = cardNumber;
            ClientId = clientId;
            TableId = tableId;
            CardStatus = cardStatus;
            Itens = itens;
        }

        public Card(int cardId, int cardNumber, Client clientId, Table tableId, EStatus cardStatus)
        {
            CardId = cardId;
            CardNumber = cardNumber;
            ClientId = clientId;
            TableId = tableId;
            CardStatus = cardStatus;
        }

        public void AddItem(Item item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(Item item)
        {
            if(Itens.Contains(item))
                Itens.Remove(item);
        }

        public int GetSumItens()
        {
            return Itens.Count;
        }

        public double GetCardPrice()
        {
            var cardPrice = 0.00;
            foreach (var item in Itens)
            {
                cardPrice += item.ItemPrice;
            }
            return Math.Round(cardPrice, 2);
        }
    }
}
