using System;
using System.Collections.Generic;
using WindowsFormsUPSKILLINGGAMA.DAL.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA.DAL
{

    public class GenericRepository<T> : IBaseRepository<T>
    {
        private readonly IBaseRepository<T> _entity;

        public GenericRepository(IBaseRepository<T> entity)
        {
            _entity = entity;
        }

        public List<T> Listar(T entity)
        {
            throw new NotImplementedException();
        }

        public T Recuperar(T entity)
        {
            throw new NotImplementedException();
        }
        public T Cadastrar(T entity)
        {
            throw new NotImplementedException();
        }

        public T Alterar(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
