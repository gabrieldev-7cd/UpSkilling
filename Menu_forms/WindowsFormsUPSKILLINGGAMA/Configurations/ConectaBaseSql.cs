
using System;
using System.IO;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;

namespace WindowsFormsUPSKILLINGGAMA.Configurations
{
    public class ConectaBaseSql
    {
        public static SQLiteConnection Conexao()
        {
            var src = "../../Configurations/database.sqlite";
            try
            {
                //Valida se a base existe;
                if (!File.Exists(src))
                {
                    SQLiteConnection.CreateFile(src);
                }

                return new SQLiteConnection($"data source={src}; version=3;");
            }
            catch(Exception ex)
            {
                throw new Exception($"Não foi possível iniciar a base, {ex}");
            }
        }
    }
}
