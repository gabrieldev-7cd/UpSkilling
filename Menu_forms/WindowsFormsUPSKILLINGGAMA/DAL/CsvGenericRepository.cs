
using System.Collections.Generic;
using System;
using WindowsFormsUPSKILLINGGAMA.DAL.Interfaces;
using System.IO;
using CsvHelper.Configuration;
using System.Globalization;
using CsvHelper;
using System.Linq;
using WindowsFormsUPSKILLINGGAMA.Models;
using System.Text.Json;

namespace WindowsFormsUPSKILLINGGAMA.DAL
{
    public class CsvGenericRepository<T> : IBaseRepository<T> where T : ModelBase
    {
        private string _nomeArquivo;
        private string _path;
        private readonly CsvConfiguration _csvConfiguration;

        public CsvGenericRepository()
        {
            _nomeArquivo = $"{typeof(T).Name.ToLower().Remove((typeof(T).Name.ToLower().Length - 5), 5)}s.csv";
            _path = "../../Configurations/" + _nomeArquivo;

            _csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true };
        }


        public List<T> Listar()
        {
            if (!File.Exists(_path)) return new List<T>();

            using (var reader = new StreamReader(_path))
            {
                using (var csv = new CsvReader(reader, _csvConfiguration))
                {
                    IEnumerable<T> entidades = csv.GetRecords<T>();
                    return entidades.ToList();
                }
            }
        }

        public T Recuperar(int id)
        {
            var entidades = Listar();
            return entidades.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool Cadastrar(T entity)
        {
            var entidades = Listar();
            entidades.Add(entity);

            if(entity == null) return false;

            using(var writer = new StreamWriter(_path))
            {
                using(var csv = new CsvWriter(writer, _csvConfiguration))
                {
                    csv.WriteHeader<T>();
                    csv.NextRecord();

                    csv.WriteRecords(entidades);
                }

            }
                return true;
        }

        public bool Alterar(T entity)
        {
            var entidades = this.Listar();

            var entidadeAtualizar = entidades.FindIndex(x => x.Id == entity.Id);

            if (entidadeAtualizar != null)
            {
                entidades.RemoveAt(entidadeAtualizar);
                entidades.Add(entity);

                using (var writer = new StreamWriter(_path))
                {
                    using (var csv = new CsvWriter(writer, _csvConfiguration))
                    {
                        csv.WriteHeader<T>();
                        csv.NextRecord();
                        csv.WriteRecords(entidades);
                    }
                }
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
            var entidades = Listar();

            if (!entidades.Any()) return 1;

            var ultimo = entidades.Last();

            if (ultimo != null && ultimo.GetType().GetProperty("Id") != null)
            {
                return Convert.ToInt32(ultimo.GetType().GetProperty("Id").GetValue(ultimo, null)) + 1;
            }

            return -1;
        }
    }
}
