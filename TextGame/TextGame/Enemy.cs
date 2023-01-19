using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Enemy
    {
        private int enemyY;
        private int enemyX;

        Enemy()
        {
            this.enemyY = num;
            this.enemyX = num;
        }

        public static Random rnd = new Random();

        int num = rnd.Next(0, 5);
    }
}
