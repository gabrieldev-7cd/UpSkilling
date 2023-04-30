﻿using System;
using System.Collections.Generic;
using WindowsFormsUPSKILLINGGAMA.DAL.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA.DAL
{

    public class GenericRepository<T> : IBaseRepository<T>
    {
        private readonly IBaseRepository<T> _repository;

        public GenericRepository(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public int ObterId()
        {
            return _repository.ObterId();
        }

        public List<T> Listar()
        {
           return _repository.Listar();
        }

        public T Recuperar(int id)
        {
            return _repository.Recuperar(id);
        }
        public bool Cadastrar(T entity)
        {
            return _repository.Cadastrar(entity);
        }

        public bool Alterar(T entity)
        {
            return _repository.Alterar(entity);
        }

        public bool Excluir(int id)
        {
            return _repository.Excluir(id);
        }
    }
}
