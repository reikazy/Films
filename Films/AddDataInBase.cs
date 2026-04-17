using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class AddDataInBase
    {
        public Films AddFilm(Films films)
        {
            using var conn = new SqliteConnection($"Data Source={db.ConnectionString}");
            conn.Open();

            using var cmd = new SqliteCommand("INSERT INTO Films (Name, Autor, Year) VALUES (@name, @autor, @year)", conn);
            cmd.Parameters.AddWithValue("@name", films.name);
            cmd.Parameters.AddWithValue("@autor", films.autor);
            cmd.Parameters.AddWithValue("@year", films.year);
            cmd.ExecuteNonQuery();

            films.Id = GetId(conn);

            return films;

        }
        public int GetId(SqliteConnection conn)
        {
            using var cmd = new SqliteCommand("SELECT last_insert_rowid()", conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            return id;
        }
    }

}
