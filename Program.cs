using System;

namespace FastPace
{
    internal class Program
    {
        static void Main(string[] args)
        {

            oneDayTeam odt = new oneDayTeam();
            string ch;

            do
            { 
                Console.Write("Enter 1. Add Player 2. Remove Player by Id 3. Get Player By Id 4. Get Player by Name 5. Get All Players: ");
                ch = Console.ReadLine();

                switch (ch)
                {
                    case "1":
                        Player newPlayer = new Player();
                        Console.Write("Enter Player Id: ");
                        newPlayer.PlayerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name: ");
                        newPlayer.Name = Console.ReadLine();
                        Console.Write("Enter Player Age: ");
                        newPlayer.Age = Convert.ToInt32(Console.ReadLine());
                        odt.Add(newPlayer);
                        break;
                    case "2":
                        Console.Write("Enter Player Id to Remove: ");
                        odt.Remove(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "3":
                        Console.Write("Enter Player Id: ");
                        odt.GetPlayerById(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "4":
                        Console.Write("Enter Player Name: ");
                        odt.GetPlayerByName(Console.ReadLine());
                        break;
                    case "5":
                        odt.GetAllPlayers();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.Write("Do you want to continue (yes/no)?: ");
                ch = Console.ReadLine();
            } while (ch.ToLower() == "yes");
        }
    }
}