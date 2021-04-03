using Arthesanatus.Domain.Entities;
using System.Data.Entity;

namespace Arthesanatus.Data.Context
{
    public class ArthesContext : DbContext
    {
        public ArthesContext( ) : base( "Name=ArthesDbConn" )
        {
            Database.SetInitializer<ArthesContext>( new CreateDatabaseIfNotExists<ArthesContext>() );
            Database.Initialize( false );

        }

        public DbSet<Revista> REVISTAS { get; set; }
        public DbSet<Receita> RECEITAS { get; set; }
    }
}
