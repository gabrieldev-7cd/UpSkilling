
using System.Collections.Generic;
using System;
using WindowsFormsUPSKILLINGGAMA.DAL.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA.DAL
{
    public class CsvGenericRepository<T> : IBaseRepository<T> 
    {
        public T Alterar(T entity)
        {
            throw new NotImplementedException();
        }

        public T Cadastrar(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> Listar(T entity)
        {
            throw new NotImplementedException();
        }

        public T Recuperar(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
