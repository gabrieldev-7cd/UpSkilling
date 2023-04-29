﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUPSKILLINGGAMA.Services.Interfaces
{
    public interface IBaseService<T>
    {
        List<T> Listar(T entity);
        T Recuperar(T entity);
        T Cadastrar(T entity);
        T Alterar(T entity);
        bool Excluir(T entity);
    }
}
