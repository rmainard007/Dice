using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class DiceRoll
    {
        Random _random = new Random();

        public string roll(string diceNum)
        {
            StringBuilder rolledNum = new StringBuilder();
            int numDice = Convert.ToInt32(diceNum);
            for (int i = 0; i < numDice; i++)
            {
                rolledNum.Append(" " + _random.Next(1, 7));
            }
            return rolledNum.ToString();

        }
    }
}
