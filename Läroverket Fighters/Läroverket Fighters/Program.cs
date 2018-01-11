using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Läroverket_Fighters
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            //Character HP
            int playerHP = randomizer.Next(25, 50);
            int enemyHP = randomizer.Next(5, 30);

            //Character damage
            int playerDmg = randomizer.Next(2, 10);
            int enemyDmg = randomizer.Next(2, 10);

            string[] enemyNames =
            {
                "Pelle",
                "Niklas",
                "Johansson",
                "Rektorn",
                "Jonas"
            };
            string enemyName = 
                enemyNames[randomizer.Next(0, enemyNames.Length)];

            Console.Write(enemyName);
            Console.ReadKey();
        }
    }
}
