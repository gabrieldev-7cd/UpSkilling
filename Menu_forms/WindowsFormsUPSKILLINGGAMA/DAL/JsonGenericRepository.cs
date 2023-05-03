
using System.Collections.Generic;
using System;
using WindowsFormsUPSKILLINGGAMA.DAL.Interfaces;
using System.IO;
using System.Text.Json;
using System.Linq;
using WindowsFormsUPSKILLINGGAMA.Models;

namespace WindowsFormsUPSKILLINGGAMA.DAL
{
    public class JsonGenericRepository<T> : IBaseRepository<T> where T : ModelBase
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
            var entidades = Listar();

            return entidades.Where(x => x.Id == id).FirstOrDefault();
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
            var entidades = this.Listar();

            var entidadeAtualizar = entidades.FindIndex(x => x.Id == entity.Id);

            if(entidadeAtualizar != null)
            {
                entidades.RemoveAt(entidadeAtualizar);
                entidades.Add(entity);

                string stringJson = JsonSerializer.Serialize(entidades);
                File.WriteAllText(_path, stringJson);

                return true;
            }

            return false;
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
                return Convert.ToInt32(ultimo.GetType().GetProperty("Id").GetValue(ultimo, null)) + 1;
            }

            return -1;
        }
    }
}
