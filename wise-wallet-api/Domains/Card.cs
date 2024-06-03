using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using wise_wallet_api.Domains.Enums;

namespace wise_wallet_api.Domains
{
    [Table("cards")]
    public class Card
    {
        [Column("CardId")]
        public int CardId { get; set; }
        [Column("CardNumber")]
        public int CardNumber { get; set; }
        [Column("ClientId")]
        public int ClientId { get; set; }
        [Column("TableId")]
        public int TableId { get; set; }
        [Column("CardStatus")]
        public EStatus CardStatus { get; set; }
    }
}
