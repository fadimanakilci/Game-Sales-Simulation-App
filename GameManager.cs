using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class GameManager
    {
        int sayac = 1;
        public void Add(List<Game> games)
        {
            // Yeni game tanımlandı
            Game game1 = new Game();
            // Yeni game in bilgileri alındı
            Console.WriteLine(sayac + ". Game ID:");
            game1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayac + ". Game Name:");
            game1.GameName = Console.ReadLine();
            Console.WriteLine(sayac + ". Game Price:");
            game1.GamePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayac + ". Game Released Year:");
            game1.ReleasedYear = Convert.ToInt32(Console.ReadLine());
            games.Add(game1);
            Console.WriteLine("\n");
            sayac++;
        }

        public void Remove(List<Game> games, int id)
        {
            for (var i = 0; i < games.Count; i++)
            {
                Game game = games[i];
                if (game.Id == id)
                {
                    games.RemoveAt(i);
                    Console.WriteLine("Game with id number " + id + " has been removed from the list.\n");
                }
                else
                {
                    Console.WriteLine("There are no games with the entered id value.\n");
                }
            }
        }

        public void List(List<Game> games)
        {
            Console.WriteLine("\n______________________________________________\n\n\t\t~~~~ GAMES LIST ~~~~\n");
            int i = 1;
            foreach (var game in games)
            {
                Console.WriteLine(i + ". Game ID:\t" + game.Id);
                Console.WriteLine(i + ". Game Name:\t" + game.GameName);
                Console.WriteLine(i + ". Game Price:\t" + game.GamePrice);
                Console.WriteLine(i + ". Released Year:\t" + game.ReleasedYear);
                Console.WriteLine("\n");
                i++;
            }
        }
    }
}
