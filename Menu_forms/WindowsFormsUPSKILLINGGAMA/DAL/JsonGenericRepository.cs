
using System.Collections.Generic;
using System;
using WindowsFormsUPSKILLINGGAMA.DAL.Interfaces;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace WindowsFormsUPSKILLINGGAMA.DAL
{
    public class JsonGenericRepository<T> : IBaseRepository<T>
    {
        private string _nomeArquivo;
        private string _path;
        
        public JsonGenericRepository()
        {
            _nomeArquivo = $"{typeof(T).Name.ToLower().Remove((typeof(T).Name.ToLower().Length - 5), 5)}s.json";
            _path = "../../Configurations/" + _nomeArquivo;
        }

        public List<T> Listar()
        {
            if (!File.Exists(_path)) return new List<T>();

            string stringJson = File.ReadAllText(_path);

            Type tipoLista = typeof(List<>).MakeGenericType(typeof(T));
            var lista = JsonSerializer.Deserialize(stringJson, tipoLista);

            if (lista == null) return new List<T>();

            List<T> entidades = (List<T>)lista;
            return entidades;
        }

        public T Recuperar(int id)
        {
            throw new NotImplementedException();
        }
        public bool Cadastrar(T entity)
        {
            if (entity == null) return false;

            var entidades = this.Listar();
            entidades.Add(entity);

            string stringJson = JsonSerializer.Serialize(entidades);
            File.WriteAllText(_path, stringJson);

            return true;
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
            string stringJson = File.ReadAllText(_path);

            Type tipoLista = typeof(List<>).MakeGenericType(typeof(T));
            var lista = JsonSerializer.Deserialize(stringJson, tipoLista);

            List<T> entidades = (List<T>)lista;

            if (!entidades.Any()) return 1;

            var ultimo = entidades.Last();

            if(ultimo != null && ultimo.GetType().GetProperty("Id") != null)
            {
                return Convert.ToInt32(ultimo.GetType().GetProperty("Id")) + 1;
            }

            return -1;
        }
    }
}
