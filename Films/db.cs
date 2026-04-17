using Microsoft.Data.Sqlite;
using Films;

namespace Films
{




    public class db
    {
        public static readonly string ConnectionString = Path.Combine(AppContext.BaseDirectory, @"..\..\..\database.db");

        public static List<Films> GetFilms()
        {
            using var conn = new SqliteConnection($"Data Source={ConnectionString}");
            conn.Open();

            List<Films> films = new();
            using var cmd = new SqliteCommand("SELECT * FROM Films", conn);

            using var reader = cmd.ExecuteReader();

            //var table = new DataTable();
            //table.Load(reader);

            while (reader.Read())
            {
                films.Add(new Films
                {
                    Id = reader.GetInt32(0),
                    name = reader.GetString(1),
                    autor = reader.GetString(2),
                    year = reader.GetString(3)
                }); // Маппинг
            }

            return films;
        }
    }
}
