using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Enemy
    {
        public static Random rnd = new Random();

        private int enemyY;
        private int enemyX;

        public Enemy()
        {
            enemyY = rnd.Next(1, 5);
            enemyX = rnd.Next(1, 5);

            while (enemyX == 3 && enemyY == 3)
            {
                enemyY = rnd.Next(1, 5);
                enemyX = rnd.Next(1, 5);
            }
        }

        public void printValues()
        {
            Console.WriteLine(enemyY);
            Console.WriteLine(enemyX);
        }

    }
}
