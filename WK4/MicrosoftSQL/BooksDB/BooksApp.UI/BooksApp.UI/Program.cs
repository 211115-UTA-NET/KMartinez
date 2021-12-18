//SQL.Send("SELECT * FROM Books");

using System.Data.SqlClient;

//SqlDataReader reader = new();


string connectionString = "";
using SqlConnection connection = new(connectionString);