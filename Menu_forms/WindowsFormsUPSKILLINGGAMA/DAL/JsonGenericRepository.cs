
using System.Collections.Generic;
using System;
using WindowsFormsUPSKILLINGGAMA.DAL.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA.DAL
{
    public class JsonGenericRepository<T> : IBaseRepository<T>
    {
        public List<T> Listar()
        {
            throw new NotImplementedException();
        }
        public T Recuperar(int id)
        {
            throw new NotImplementedException();
        }
        public bool Cadastrar(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Alterar(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public int ObterId()
        {
            throw new NotImplementedException();
        }
    }
}
