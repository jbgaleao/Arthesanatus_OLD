using Arthesanatus.Domain.Entities;
using System.Linq;

namespace Arthesanatus.Repository.Interfaces
{

    public interface IRepositorio<T> where T : class

    {
        void Adicionar( T item );

        void Remover( T item );

        void Editar( T item );

        T ObtemPorId( object id );

        IQueryable<T> Tudo( );

    }

}
