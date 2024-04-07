using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using wise_wallet_api.Domains;

namespace wise_wallet_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}
