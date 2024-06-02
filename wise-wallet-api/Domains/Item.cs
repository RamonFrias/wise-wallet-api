using System.ComponentModel.DataAnnotations.Schema;

namespace wise_wallet_api.Domains
{
    [Table("itens")]
    public class Item
    {
        [Column("ItemId")]
        public int ItemId { get; set; }
        [Column("ItemName")]
        public string ItemName { get; set; }
        [Column("ItemPrice")]
        public double ItemPrice { get; set; }
        [Column("ItemQuantity")]
        public int ItemQuantity { get; set; }
        [Column("CardId")]
        public int CardId { get; set; }

    }
}
