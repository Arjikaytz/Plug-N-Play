using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugAndPlay.Common;
using System.Data;
using System.Data.SqlClient;



namespace PlugAndPlay.Data
{
    public class DBGearRepository : IGearRepository
    {
        private static string connectionString =
            "Data Source=localhost\\SQLEXPRESS02; Initial Catalog=PlugNPlayDB; Integrated Security=True; TrustServerCertificate=True;";

        public List<GearItem> GetGuitars()
        {
            return GetGearByType("Guitar");
        }

        public List<GearItem> GetPedals()
        {
            return GetGearByType("Pedal");
        }

        public List<GearItem> GetAmplifiers()
        {
            return GetGearByType("Amplifier");
        }

        private List<GearItem> GetGearByType(string type)
        {
            List<GearItem> result = new List<GearItem>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, Type FROM GearItems WHERE Type = @Type";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Type", type);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    GearItem item = new GearItem
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Type = reader["Type"].ToString()
                    };
                    result.Add(item);
                }

                connection.Close();
            }

            return result;
        }

        public void Add(GearItem item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO GearItems (Name, Type) VALUES (@Name, @Type)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Type", item.Type);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public bool Update(GearItem item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE GearItems SET Name = @Name, Type = @Type WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Type", item.Type);
                command.Parameters.AddWithValue("@Id", item.Id);

                connection.Open();
                int affected = command.ExecuteNonQuery();
                connection.Close();

                return affected > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM GearItems WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                int affected = command.ExecuteNonQuery();
                connection.Close();

                return affected > 0;
            }
        }

        public GearItem? SearchByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, Type FROM GearItems WHERE Name = @Name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    GearItem item = new GearItem
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Type = reader["Type"].ToString()
                    };

                    connection.Close();
                    return item;
                }

                connection.Close();
                return null;
            }
        }
    }
}
