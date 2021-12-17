using System.Data.SqlClient;
 
string connectionString = File.ReadAllText(".txt");

void ListBooks()
{

   
    using SqlConnection connection = new(connectionString);
    connection.Open();
    string commandText = "SELECT * FROM Books;";
    using SqlCommand command = new(commandText, connection);
    using SqlDataReader reader = command.ExecuteReader();



    while (reader.Read())
    {
       
        string title = reader.GetString(0);

        int pages = reader.GetInt32(2);

        Console.WriteLine($"\"{title}\" with {pages} pages");
    }

}

void AddNewBook()
{
    using SqlConnection connection = new(connectionString);
    connection.Open();
    using SqlCommand command = new($"INSERT INTO Books (Titles, Pages) VALUES ('{title]', {pages});", connection)

    connection.Close();
}