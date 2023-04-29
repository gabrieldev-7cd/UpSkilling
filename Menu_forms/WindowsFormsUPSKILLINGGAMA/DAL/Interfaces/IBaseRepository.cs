
using System.Collections.Generic;

namespace WindowsFormsUPSKILLINGGAMA.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        List<T> Listar(T entity);
        T Recuperar(T entity);
        T Cadastrar(T entity);
        T Alterar(T entity);
        bool Excluir(T entity);
    }
}
