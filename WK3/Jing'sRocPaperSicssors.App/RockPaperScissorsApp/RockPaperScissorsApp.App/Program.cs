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
using System;
using System.Xml.Serialization;
namespace RockPaperScissorsApp.APP
{
    public class Program
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RockPaperScissors App");
            string? name = null;
            while (name == null || name.Length <= 0)
            {
                Console.Write("Enter an valid username: ");
                name = Console.ReadLine();
            }


          
            List<Record>? records = ReadHistoryFromFile("../../../history.xml");
            Game game = new Game(name, records);

            Console.WriteLine($"[ Welcome Player {game.PlayerName}. ]");
            while (true)
            {
                Console.WriteLine();
                Console.Write("Play a round? (y/n) ");
                string? input = Console.ReadLine();
                if (input == null || input.ToLower() != "y")
                {
                    Console.WriteLine("--- End of the Game ---");
                    break;
                }
                game.PlayRound();
            }


            Console.WriteLine("--- Game Records ---");
            game.Summary();

            WriteHistoryToFile(game, "../../../history.xml");
        }

        //Writing to a file
        private static void WriteHistoryToFile(Game game, string filePath)
        {
            string xml = game.SerializedAsXml();
            File.WriteAllText(filePath, xml);

        }


        ////Reading from a file
        ////Old
        //private static List<Record>? ReadHistoryFromFile(string filePath)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Record>));
        //    StreamReader reader = null;
        //    try
        //    {
        //        reader = new(filePath);
        //        List<Record>? records = (List<Record>?)serializer.Deserialize(reader);

        //        return records;
        //    }
        //    catch (FileNotFoundException)
        //    {

        //        return null;
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //            reader.Close();
        //    }
        //}

        New shorter way
        private static List<Record>? ReadHistoryFromFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Record>));
            using StreamReader? reader = new(filePath);
            try
            {
                var records = new(filePath);
                List<Record>? records = (List<Record>?)serializer.Deserialize(reader);

                return records;
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

    }
}