using System;
using System.Collections.Generic;
using System.Text;

namespace Dizaj_u_objektno_orijentiranom_sustavu_LV2
{
    class Dice
    {
        private int numberOfSides;
        private Random random;
        private RandomGenerator RandGenerator;
        //1.zadatak
        /*
        public Dice(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = new Random();
        }
        */
        //2.zadatak
        /*
        public Dice(int numberOfSides, Random rand)
        {
            this.numberOfSides = numberOfSides;
            this.random = rand;
        }
        */
        public Dice(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }
        // prvi i drugi zadatak
        /*
        public int Roll()
        {
            rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
        */
        //3. Zadatak
        /*
        public int Roll()
        {
            RandGenerator=RandomGenerator.GetInstance();
            int rolledNumber = RandGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
        */
    }
}
