
using System.Data.SqlClient;

string connectionString = File.ReadAllText("C:\Users\mkare_wyte20y\Revature\NOTFORGITHUB\TextFile1.txt");
using SqlConnection connection = new(connectionString);
connection.Open();

string commandText = "SELECT * FROM Books;*";

using SqlCommand command = new(commandText, connection);
using SqlDataReader reader = command.ExecuteReader();

while (reader.Read())
{
    string title = reader.GetString(0);
    //string title = (string)reader[0];
    int pages = reader.GetInt32(2);

    Console.WriteLine($"\" {title}\"with {pages} pages");
}