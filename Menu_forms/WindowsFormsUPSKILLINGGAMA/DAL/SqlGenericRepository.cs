using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.DAL.Interfaces;
using System.Linq;

namespace WindowsFormsUPSKILLINGGAMA.DAL
{
    public class SqlGenericRepository<T> : IBaseRepository<T>
    {
        private readonly string _nomeTabela;

        public SqlGenericRepository()
        {
            _nomeTabela = $"{typeof(T).Name.ToLower().Remove((typeof(T).Name.ToLower().Length - 5), 5)}s";
        }

        public int ObterId()
        {
            int id = 1;
            var sql = $"SELECT MAX(id) FROM {_nomeTabela};";

            using (var conexao = ConectaBaseSql.Conexao())
            {
                conexao.Open();

                using (var command = new SQLiteCommand(sql, conexao))
                {
                    SQLiteDataReader readr = command.ExecuteReader();
                    if (readr.HasRows)
                    {
                        while(readr.Read())
                        {
                            id = Convert.ToInt32(readr[0]) + 1;
                        }
                    }

                    return id;
                }
            }
        }

        public List<T> Listar()
        {
            List<T> entidades = new List<T>();

            using (var conexao = ConectaBaseSql.Conexao())
            {
                SQLiteDataAdapter dAdapter = null;
                DataTable dTable = new DataTable();
            
                var sql = $"SELECT * FROM {_nomeTabela};";
                conexao.Open();

                try
                {
                    using (var command = new SQLiteCommand(sql, conexao))
                    {
                        SQLiteDataReader readr = command.ExecuteReader();

                        while (readr.Read())
                        {
                            var entidade = Activator.CreateInstance(typeof(T));

                            if (entidade == null) 
                                return new List<T>();

                            foreach (var pi in entidade.GetType().GetProperties())
                            {
                                var piSet = entidade.GetType().GetProperty(pi.Name);

                                if (piSet == null) 
                                    continue;

                                piSet.SetValue(entidade, readr[pi.Name]);
                            }

                            entidades.Add((T)entidade);
                        }
                        return entidades;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Houve um problema ao ler da base: {ex}");
                }
            }
        }

        public T Recuperar(int id)
        {
            using (var conexao = ConectaBaseSql.Conexao())
            {
                conexao.Open();

                var entidade = default(T);

                var sql = $"SELECT * FROM {_nomeTabela} WHERE id = @id;";
                using (var command = new SQLiteCommand(sql, conexao))
                {
                    command.Parameters.AddWithValue("@id", id);

                    try
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                entidade = Activator.CreateInstance<T>();

                                foreach (var property in entidade.GetType().GetProperties())
                                {
                                    var value = reader[property.Name];
                                    if (value != DBNull.Value)
                                    {
                                        property.SetValue(entidade, value);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Houve um problema ao ler da base: {ex}");
                    }
                }

                if (entidade == null)
                {
                    throw new Exception($"Não foi encontrado registro com id {id}");
                }

                return entidade;
            }
        }

        public bool Cadastrar(T entity)
        {
            if (entity == null) 
                return false;

            var tipoEntidade = entity.GetType();
            var campos = string.Join(",", tipoEntidade.GetProperties().Select(pi => pi.Name.ToLower()));
            var valores = string.Join(",", tipoEntidade.GetProperties().Select(pi => "@" + pi.Name));

            var sql = $"INSERT INTO {_nomeTabela} ({campos}) VALUES ({valores})";

            using (var conexao = ConectaBaseSql.Conexao())
            {
                conexao.Open();

                using (var command = new SQLiteCommand(sql, conexao))
                {
                    foreach (var pi in tipoEntidade.GetProperties())
                    {
                        var valor = pi.GetValue(entity);

                        if (valor == null) 
                            continue;

                        command.Parameters.AddWithValue(pi.Name.ToLower(), valor);
                    }

                    command.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool Alterar(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            var sql = $"DELETE FROM {_nomeTabela} WHERE ID = @id;";

            using (var conexao = ConectaBaseSql.Conexao())
            {
                conexao.Open();

                try
                { 
                    using (var command = new SQLiteCommand(sql, conexao))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int updatedRows = command.ExecuteNonQuery();

                        if (updatedRows != 1)
                        {
                            return false;
                        }

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Não foi possível realizar a exclusão: {ex}");
                }
            }

        }
    }
}
