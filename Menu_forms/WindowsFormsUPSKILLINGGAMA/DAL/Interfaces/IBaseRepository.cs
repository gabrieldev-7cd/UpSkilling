
using System.Collections.Generic;

namespace WindowsFormsUPSKILLINGGAMA.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        int ObterId();
        List<T> Listar();
        T Recuperar(int id);
        bool Cadastrar(T entity);
        bool Alterar(T entity);
        bool Excluir(int id);
    }
}
