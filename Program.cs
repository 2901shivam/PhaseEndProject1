using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject1
{
    public class Program
    {
        static void Main(string[] args)
        {



            string userChoice="yes";

            ITeam team = new OneDayTeam();


            do
            {


                try
                {
                    Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3:Get Player by Id 4:Get Player by Name 5:Get All Players");



                    int Choice = int.Parse(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1:
                            {
                                Console.Write("Enter Player Id:");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Enter Player Name:");
                                string name = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Enter Player Age:");
                                int age = int.Parse(Console.ReadLine());
                                Player player = new Player();
                                player.PlayerId = id;
                                player.PlayerName = name;
                                player.PlayerAge = age;
                              
                                team.Add(player);
                                break;

                            }
                        case 2:
                            {
                                Console.Write("Enter Player Id to remove:");
                                int id = int.Parse(Console.ReadLine());
                                Player player = new Player();
                                player.PlayerId = id;
                              
                                team.Remove(id);
                                break;

                            }
                        case 3:
                            {
                                Console.Write("Enter Player Id:");
                                int id = int.Parse(Console.ReadLine());
                                Player player = team.GetPlayerById(id);
                                if (player != null)
                                {
                                    Console.WriteLine("Player Id:" + player.PlayerId + "Player Name:" + player.PlayerName + "Player Age:" + player.PlayerAge);
                                }
                                else
                                {
                                    Console.WriteLine("Player Details are not found");
                                }
                                break;

                            }
                        case 4:
                            {
                                Console.Write("Enter Player Name:");
                                string name = Console.ReadLine();
                                Player player = team.GetPlayerByName(name);
                               
                                if (player != null)
                                {
                                    Console.WriteLine("Player Id:" + player.PlayerId + "Player Name:" + player.PlayerName + "Player Age:" + player.PlayerAge);
                                }
                                else
                                {
                                    Console.WriteLine("Player Details are not found");
                                }
                                break;

                            }

                        case 5:
                            {
                                List<Player> players = team.GetAllPlayers();

                                foreach (Player player in players)
                                {
                                    Console.WriteLine($"Player Id: {player.PlayerId}, Player Name: {player.PlayerName}, Player Age: {player.PlayerAge}");
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid input");
                                userChoice = "no";
                                break;
                            }


                    }
                    Console.Write("Do you want to perform another task? (yes/no): ");
                    userChoice = Console.ReadLine().Trim().ToLower();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Occured" + e.Message);
                }

            }
            while (userChoice=="yes");
           
            


        }
    }
}
