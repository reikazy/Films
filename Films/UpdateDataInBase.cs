using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    internal class UpdateDataInBase
    {
        public static void Update(object data)
        {
            using var conn = new SqliteConnection($"Data Source={db.ConnectionString}");
            conn.Open();

            if (data is Films field)
            {
                using var cmd = new SqliteCommand(
                    "UPDATE Films SET Name = @name, Autor = @autor, Year = @year WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@name", field.name);
                cmd.Parameters.AddWithValue("@autor", field.autor);
                cmd.Parameters.AddWithValue("@year", field.year);
                cmd.Parameters.AddWithValue("@id", field.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
