/*
 * play RPS with AI/Computer
 * required features:
 * - play multiple rounds
 * - get a summary/record of all the rounds played so far
 *
 * stretch goal features:
 * - persistence (save data somehow, it will remember past game history)
 * - play more complex variants of RPS (like RPS+lizard+spock)
 * - logging (to help with debugging the app if something goes wrong)
 * - more than 2 players
 * - support both player vs player and player vs computer
 * - difficulty settings for the computer (remembers your moves and tries to predict)
 * - timmer limit
 *
 * - In general, we want to write something simple
 *   but in a way that allows for extending it/generalizing it in the future.
 */

using System.Text.Json;

namespace RPSConsoleApp.UI
{
    public class Program
    {
        public static readonly HttpClient HttpClient = new();
        public async static Task Main(string[] args)
        {
            Console.WriteLine("Welcome to RockPaperScissors App");
            string? name = null;
            while (name == null || name.Length <= 0)
            {
                Console.Write("Enter an valid username: ");
                name = Console.ReadLine();
            }

            //HttpResponseMessage response = await HttpClient.GetAsync($"https://localhost:7046/api/rounds?player={name}");
            var rounds = await HttpClient.GetFromJsonAsync<List<Round>>($"https://localhost:7046/api/rounds?player={name}");


            //response.Content.Headers.ContentType == "application/json";
            string json = response.Content.ReadAsStringAsync();
            var rounds = JsonSerializer.Deserialize<List<Round>>(json)
            //string connectionString = await File.ReadAllTextAsync("C:/revature/richard-rps-db.txt");
            //IRepository repository = new SqlRepository(connectionString);

            //RandomMoveDecider moveDecider = new RandomMoveDecider();
            //Game game = new(name, moveDecider, repository);
            //Console.WriteLine($"[ Welcome Player {game.PlayerName}. ]");
            //while (true)
            //{
            //    Console.WriteLine();
            //    Console.Write("Play a round? (y/n) ");
            //    string? input = Console.ReadLine();
            //    if (input == null || input.ToLower() != "y")
            //    {
            //        Console.WriteLine("--- End of the Game ---");
            //        break;
            //    }
            //    game.PlayRound();
            //}
            //Console.WriteLine("--- Game Records ---");
            //// synchronously wait on the Task (can't do anything else in the meantime)
            //// bad! unless it's the Main method, where clearly there's no "other code" that could be running
            ////Console.WriteLine(game.SummaryAsync().Result);
            //Console.WriteLine(await game.SummaryAsync());
        }
    }
}
