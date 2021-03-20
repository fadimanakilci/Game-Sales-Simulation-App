using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            List<Game> games = new List<Game>();
            List<Gamer> gamers = new List<Gamer>();
            List<Campaign> hCampaigns = new List<Campaign>();
            List<Campaign> sCampaigns = new List<Campaign>();
            ICampaignService holidayManager = new HolidayCampaignManager();
            ICampaignService springManager = new SpringCampaignManager();
            List<ICampaignService> campaigns = new List<ICampaignService>(){holidayManager,springManager};
            IValidationService tcManager = new TcValidationManager();
            List<IValidationService> validations = new List<IValidationService>() {tcManager};
            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager();
            SaleManager saleManager = new SaleManager();

            Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t~~~~ GAME OPERATIONS ~~~~\n");
                    Console.WriteLine("Press 'A' key to add game.");
                    Console.WriteLine("Press 'L' key to list games.");
                    Console.WriteLine("Press 'R' key to remove game.");
                    Console.WriteLine("Esc Press: Exit");
                    do
                    {
                        keyInfo = Console.ReadKey(true);
                        // Add Game
                        if (keyInfo.Key == ConsoleKey.A)
                        {
                            gameManager.Add(games);
                        }
                        // List Games
                        else if (keyInfo.Key == ConsoleKey.L)
                        {
                            gameManager.List(games);
                        }
                        // Removed Game
                        else if (keyInfo.Key == ConsoleKey.R)
                        {
                            Console.WriteLine("Enter the ID of the game to be removed:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            gameManager.Remove(games, id);
                        }
                        else if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please press one of the keys indicated");
                        }
                    } while (keyInfo.Key != ConsoleKey.Escape);
                }
                else if (keyInfo.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t~~~~ GAMER ACTIONS ~~~~\n");
                    Console.WriteLine("Press 'A' key to add gamer.");
                    Console.WriteLine("Press 'L' key to list gamers.");
                    Console.WriteLine("Press 'R' key to remove gamer.");
                    Console.WriteLine("Press 'U' key to update gamer.");
                    Console.WriteLine("Press 'V' key to validation gamer.");
                    Console.WriteLine("Esc Press: Exit");
                    do
                    {
                        keyInfo = Console.ReadKey(true);
                        // Add Gamer 
                        if (keyInfo.Key == ConsoleKey.A)
                        {
                            gamerManager.Add(gamers);
                        }
                        // List Gamers
                        else if (keyInfo.Key == ConsoleKey.L)
                        {
                            gamerManager.List(gamers);
                        }
                        // Removed Gamer
                        else if (keyInfo.Key == ConsoleKey.R)
                        {
                            Console.WriteLine("Enter the ID of the gamer to be removed:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            gamerManager.Remove(gamers, id);
                        }
                        // Updated Gamer
                        else if (keyInfo.Key == ConsoleKey.U)
                        {
                            Console.WriteLine("Enter the ID of the gamer to be updated:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            gamerManager.Update(gamers, id);
                        }
                        // Validated Gamer
                        else if (keyInfo.Key == ConsoleKey.V)
                        {
                            Console.WriteLine("Enter the ID of the gamer to be validated:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            for (var i = 0; i < gamers.Count; i++)
                            {
                                Gamer gamer = gamers[i];
                                if (gamer.Id == id)
                                {
                                    IValidationService tcValidationManager = new TcValidationManager();
                                    tcValidationManager.Validate(gamers, id, i);
                                }
                                else
                                {
                                    Console.WriteLine("There are no gamers with the entered id value.\n");
                                }
                            }

                        }
                        else if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please press one of the keys indicated");
                        }
                    } while (keyInfo.Key != ConsoleKey.Escape);
                }
                else if (keyInfo.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t~~~~ GAME Sales ~~~~\n");
                    Console.WriteLine("Press the 'A' key to see all campaigns.");
                    Console.WriteLine("Press the 'T' button to see the Term Campaigns.");
                    Console.WriteLine("Press the 'C' key for campaign transactions.");
                    Console.WriteLine("Press the 'S' key for purchases.");
                    Console.WriteLine("Esc Press: Exit\n");
                    do
                    {
                        keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.A)
                        {
                            holidayManager.List(hCampaigns);
                            springManager.List(sCampaigns);
                        }
                        else if (keyInfo.Key == ConsoleKey.T)
                        {
                            Console.Clear();
                            Console.WriteLine("There are two active term campaigns.\nPress the '1' button for the spring campaign.\nPress the '2' button for the holiday campaign.\n");
                            do
                            {
                                keyInfo = Console.ReadKey(true);
                                if (keyInfo.Key == ConsoleKey.D1)
                                {
                                    springManager.List(sCampaigns);
                                }
                                else if (keyInfo.Key == ConsoleKey.D2)
                                {
                                    holidayManager.List(hCampaigns);
                                }
                                else if (keyInfo.Key == ConsoleKey.Escape)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please press one of the keys indicated.\nEsc Press: Exit\n");
                                }
                            } while (keyInfo.Key != ConsoleKey.Escape);
                        }
                        else if (keyInfo.Key == ConsoleKey.C)
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t~~~~ CAMPAIGN TRANSACTIONS ~~~~\n");
                            Console.WriteLine("Press 'A' key to add campaign.");
                            Console.WriteLine("Press 'L' key to list campaigns.");
                            Console.WriteLine("Press 'R' key to remove campaign.");
                            Console.WriteLine("Press 'U' key to update campaign.");
                            Console.WriteLine("Esc Press: Exit\n");
                            do
                            {
                                keyInfo = Console.ReadKey(true);
                                // Add Campaign 
                                if (keyInfo.Key == ConsoleKey.A)
                                {
                                    Console.WriteLine("Press the '1' button for the spring campaign.\nPress the '2' button for the holiday campaign.\nEsc Press: Exit\n");
                                    do
                                    {
                                        keyInfo = Console.ReadKey(true);
                                        if (keyInfo.Key == ConsoleKey.D1)
                                        {
                                            springManager.Add(sCampaigns);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.D2)
                                        {
                                            holidayManager.Add(hCampaigns);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.Escape)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please press one of the keys indicated.\n");
                                        }
                                    } while (keyInfo.Key != ConsoleKey.Escape);
                                }
                                // List Campaigns
                                else if (keyInfo.Key == ConsoleKey.L)
                                {
                                    Console.WriteLine("Press the '1' button for the spring campaigns.\nPress the '2' button for the holiday campaigns.\nPress the '3' button for the all campaigns.\nEsc Press: Exit\n");
                                    do
                                    {
                                        keyInfo = Console.ReadKey(true);
                                        if (keyInfo.Key == ConsoleKey.D1)
                                        {
                                            springManager.List(sCampaigns);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.D2)
                                        {
                                            holidayManager.List(hCampaigns);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.D3)
                                        {
                                            springManager.List(sCampaigns);
                                            holidayManager.List(hCampaigns);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.Escape)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please press one of the keys indicated.\n");
                                        }
                                    } while (keyInfo.Key != ConsoleKey.Escape);
                                }
                                // Removed Campaign
                                else if (keyInfo.Key == ConsoleKey.R)
                                {
                                    Console.WriteLine("Press the '1' button for the spring campaigns.\nPress the '2' button for the holiday campaigns.\nEsc Press: Exit\n");
                                    do
                                    {
                                        keyInfo = Console.ReadKey(true);
                                        if (keyInfo.Key == ConsoleKey.D1)
                                        {
                                            Console.WriteLine("Enter the ID of the spring campaign to be removed:");
                                            int id = Convert.ToInt32(Console.ReadLine());
                                            springManager.Remove(sCampaigns, id);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.D2)
                                        {
                                            Console.WriteLine("Enter the ID of the holiday campaign to be removed:");
                                            int id = Convert.ToInt32(Console.ReadLine());
                                            holidayManager.Remove(hCampaigns, id);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.Escape)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please press one of the keys indicated.\n");
                                        }
                                    } while (keyInfo.Key != ConsoleKey.Escape);
                                }
                                // Updated Campaign
                                else if (keyInfo.Key == ConsoleKey.U)
                                {
                                    Console.WriteLine("Press the '1' button for the spring campaigns.\nPress the '2' button for the holiday campaigns.\nEsc Press: Exit\n");
                                    do
                                    {
                                        keyInfo = Console.ReadKey(true);
                                        if (keyInfo.Key == ConsoleKey.D1)
                                        {
                                            Console.WriteLine("Enter the ID of the spring campaign to be updated:");
                                            int id = Convert.ToInt32(Console.ReadLine());
                                            springManager.Update(sCampaigns, id);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.D2)
                                        {
                                            Console.WriteLine("Enter the ID of the holiday campaign to be updated:");
                                            int id = Convert.ToInt32(Console.ReadLine());
                                            holidayManager.Update(hCampaigns, id);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.Escape)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please press one of the keys indicated.\n");
                                        }
                                    } while (keyInfo.Key != ConsoleKey.Escape);
                                }
                                else if (keyInfo.Key == ConsoleKey.Escape)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please press one of the keys indicated.\n");
                                }
                            } while (keyInfo.Key != ConsoleKey.Escape);
                        }
                        else if (keyInfo.Key == ConsoleKey.S)
                        {
                            Console.WriteLine("Enter the gamer ID to be sold the game:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            for (var j = 0; j < gamers.Count; j++)
                            {
                                Gamer gamer = gamers[j];
                                if (gamer.Id == id)
                                {
                                    Console.WriteLine("Press the 'H' key to holiday campaigns.\nPress the 'S' key to springs campaigns.\nEsc Press: Exit\n");
                                    do
                                    {
                                        keyInfo = Console.ReadKey(true);
                                        if (keyInfo.Key == ConsoleKey.H)
                                        {
                                            saleManager.Sales(gamer, games, campaigns, hCampaigns);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.S)
                                        {
                                            saleManager.Sales(gamer, games, campaigns, sCampaigns);
                                        }
                                        else if (keyInfo.Key == ConsoleKey.Escape)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please press one of the keys indicated.\n");
                                        }
                                    } while (keyInfo.Key != ConsoleKey.Escape);

                                    Console.WriteLine("\n\nEnter the game id to be sold:");
                                    int id_ = Convert.ToInt32(Console.ReadLine());
                                    for (int k = 0; k < games.Count; k++)
                                    {
                                        Game game = games[k];
                                        if (game.Id == id_)
                                        {
                                            Console.WriteLine("\nThe sales process for the " + game.GameName + " game has been successfully completed.\n");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There are no gamers with the entered id value.\n");
                                }
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Console.WriteLine("Press the '1' key for game operations.\nPress the '2' key for gamer actions.\nPress the '3' key for game sales.\nPress the 'E' key to end the program.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please press one of the keys indicated.\n");
                        }
                    } while (keyInfo.Key != ConsoleKey.Escape);
                }
                else if (keyInfo.Key == ConsoleKey.E)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please press one of the keys indicated.\n");
                }
            } while (keyInfo.Key != ConsoleKey.E);
        }
        
    }
}
