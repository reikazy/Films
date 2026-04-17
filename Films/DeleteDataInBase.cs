using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    internal class DeleteDataInBase
    {
        public static void RemoveFilms(int id)
        {
            using var conn = new SqliteConnection($"Data Source={db.ConnectionString}");
            conn.Open();

            using var cmd = new SqliteCommand($"DELETE FROM Films WHERE id = {id}", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        
    }
}