using wise_wallet_api.Domains.Enums;

namespace wise_wallet_api.Domains
{
    public class Table
    {
        public int TableId { get; set; }
        public int TableNumber { get; set; }
        public EStatus TableStatus { get; set; }
        public string InsideLocation { get; set; }

        public Table(int tableId, int tableNumber, string insideLocation, EStatus tableStatus)
        {
            TableId = tableId;
            TableNumber = tableNumber;
            InsideLocation = insideLocation;
            TableStatus = tableStatus;
        }
    }
}
