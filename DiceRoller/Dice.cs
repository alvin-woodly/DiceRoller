using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Dice
    {
        Random random = new Random();
        
         public int RollDice(int numberOfSides)
        {
            return  random.Next(1,numberOfSides);
        }
    }
}
