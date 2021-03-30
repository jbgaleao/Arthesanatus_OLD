using Arthesanatus.Model.Entity;
using System.Data.Entity;

namespace Arthesanatus.DataBase.Context
{
    class DataContext : DbContext
    {
        public DataContext( ) : base()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Revista> REVISTAS { get; set; }
        public DbSet<Receita> RECEITAS { get; set; }
    }
}
