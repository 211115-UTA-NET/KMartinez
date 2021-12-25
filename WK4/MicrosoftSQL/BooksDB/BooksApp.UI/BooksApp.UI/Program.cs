//SQL.Send("SELECT * FROM Books");

using System.Data.SqlClient;

//SqlDataReader reader = new();

/* We could just copy and paste but instead we will call from a file outside the repo*/
string connectionString = File.ReadAllText("C:/Users/mkare_wyte20y/Revature/DQL_Database.txt");
using SqlConnection connection = new(connectionString);
connection.Open();

string commandText = "SELECT * FROM Books;";
using SqlCommand command = new (commandText, connection);
using SqlDataReader reader = command.ExecuteReader();

while (reader.Read())
{
    string title = reader.GetString(0);

    int pages = reader.GetInt32(2);

    Console.WriteLine($"\"{title}\" with {pages} pages");
}
connection.Close(); 