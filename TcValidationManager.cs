using System.Collections.Generic;

namespace InterfaceDemo
{
    class TcValidationManager : IValidationService
    {
        public bool Validate(List<Gamer> gamers, int id, int i)
        {
            Gamer gamer = gamers[i];
            // Deneme amaçlı e-devlette kayıtlı olduğunu varsaydığımız kişi bilgilerini biz verdik
            if ((gamer.TcNo == "55555555555" && gamer.Name == "Fadimana" && gamer.Surname == "Kilci" && gamer.DateOfBirth == "29.05.1997")
                || (gamer.TcNo == "66666666666" && gamer.Name == "Birsen" && gamer.Surname == "Göner" && gamer.DateOfBirth == "15.05.1997"))
            {
                System.Console.WriteLine("The gamer with the id number " + id + " has been verified by the e-government system.\n");
                return true;
            }
            else
            {
                System.Console.WriteLine("The gamer with the id number " + id + " is not available in the e-government system.\n");
                return false;
            }
        }
    }
}
