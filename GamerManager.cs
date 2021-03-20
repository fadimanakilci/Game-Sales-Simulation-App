using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class GamerManager
    {
        int sayac = 1;
        public void Add(List<Gamer> gamers)
        {
            // Yeni gamer tanımlandı
            Gamer gamer1 = new Gamer();
            // Yeni gamerın bilgileri alındı
            Console.WriteLine(sayac + ". Gamer ID:");
            gamer1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayac + ". Gamer Tc No:");
            gamer1.TcNo = Console.ReadLine();
            Console.WriteLine(sayac + ". Gamer Name:");
            gamer1.Name = Console.ReadLine();
            Console.WriteLine(sayac + ". Gamer Surname:");
            gamer1.Surname = Console.ReadLine();
            Console.WriteLine(sayac + ". Gamer Nick Name:");
            gamer1.NickName = Console.ReadLine();
            Console.WriteLine(sayac + ". Gamer Date of Birth:");
            gamer1.DateOfBirth = Console.ReadLine();
            // Oyunda ilerledikçe artacak
            gamer1.Level = 1;
            // Oyunda ilerledikçe artacak
            gamer1.Score = 0;
            // Gamers listesine gamer1 i ekledik
            gamers.Add(gamer1);
            Console.WriteLine("\n");
            sayac++;
        }

        public void List(List<Gamer> gamers)
        {
            Console.WriteLine("\n______________________________________________\n\n\t\t~~~~ GAMERS LIST ~~~~\n");
            int i = 1;
            foreach (var gamer in gamers)
            {
                Console.WriteLine(i + ". Gamer ID:\t" + gamer.Id);
                Console.WriteLine(i + ". Gamer Tc No:\t" + gamer.TcNo);
                Console.WriteLine(i + ". Gamer Name:\t" + gamer.Name);
                Console.WriteLine(i + ". Gamer Surname:\t" + gamer.Surname);
                Console.WriteLine(i + ". Gamer Nick Name:\t" + gamer.NickName);
                Console.WriteLine(i + ". Gamer Level:\t" + gamer.Level);
                Console.WriteLine(i + ". Gamer Score:\t" + gamer.Score);
                Console.WriteLine(i + ". Gamer Date of Birth:\t" + gamer.DateOfBirth + "\n");
                i++;
            }
        }

        public void Remove(List<Gamer> gamers, int id)
        {
            for (var i = 0; i < gamers.Count; i++)
            {
                Gamer gamer = gamers[i];
                if (gamer.Id == id)
                {
                    gamers.RemoveAt(i);
                    Console.WriteLine("Gamer with id number " + id + " has been removed from the list.\n");
                }
                else
                {
                    Console.WriteLine("There are no gamers with the entered id value.\n");
                }
            }
        }

        public void Update(List<Gamer> gamers, int id)
        {
            for (var i = 0; i < gamers.Count; i++)
            {
                Gamer gamer = gamers[i];
                if (gamer.Id == id)
                {
                    Console.WriteLine("Gamer information updated.\n");
                }
                else
                {
                    Console.WriteLine("There are no gamers with the entered id value.\n");
                }


            }
        }
    }
}
