using Arthesanatus.Data.Context;
using Arthesanatus.Repository.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace Arthesanatus.Repository.Implements
{
    public class Repositorio<T> : IRepositorio<T> where T : class

    {
        protected readonly ArthesContext contexto = new ArthesContext();

        public Repositorio( ArthesContext _contexto )
        {
            this.contexto = _contexto;
        }

        public Repositorio( )
        {
        }

        public virtual void Adicionar( T item )
        {
            contexto.Set<T>().Add( item );
            contexto.SaveChanges();
        }

        public virtual void Remover( T item )
        {
            contexto.Set<T>().Remove( item );
            contexto.SaveChanges();
        }

        public virtual void Editar( T item )
        {
            contexto.Entry( item ).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public virtual T ObtemPorId( object id )
        {
            return contexto.Set<T>().Find( id );
        }

        public virtual IQueryable<T> Tudo( )
        {
            return contexto.Set<T>();
        }

    }

}
