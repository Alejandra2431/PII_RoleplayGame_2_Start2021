using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleplayGame
{
    public interface ICharacter
    {
        void ReceiveAttack(int power);
        void Cure();
    }
}