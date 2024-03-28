namespace wise_wallet_api.Domains
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQuantity { get; set; }

        public Item(int itemId, string itemName, double itemPrice, int itemQuantity)
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemPrice = itemPrice;
            ItemQuantity = itemQuantity;
        }
    }
}
