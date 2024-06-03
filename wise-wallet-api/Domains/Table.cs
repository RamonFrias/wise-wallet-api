using System.ComponentModel.DataAnnotations.Schema;
using wise_wallet_api.Domains.Enums;

namespace wise_wallet_api.Domains
{
    [Table("tables")]
    public class Table
    {
        [Column("TableId")]
        public int TableId { get; set; }
        [Column("TableNumber")]
        public int TableNumber { get; set; }
        [Column("TableStatus")]
        public EStatus TableStatus { get; set; }
        [Column("InsideLocation")]
        public string InsideLocation { get; set; }
    }
}
