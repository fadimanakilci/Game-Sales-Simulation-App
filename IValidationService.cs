using System.Collections.Generic;

namespace InterfaceDemo
{
    interface IValidationService
    {
        bool Validate(List<Gamer> gamers, int id, int i);
    }
}
