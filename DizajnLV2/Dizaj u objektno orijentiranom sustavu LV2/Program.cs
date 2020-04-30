using System;
using System.Collections.Generic;

namespace Dizaj_u_objektno_orijentiranom_sustavu_LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadatak 1
            /*
            DiceRoller Roller = new DiceRoller();
            List<Dice> Listdice = new List<Dice>();
            IList<int> RollResults = new List<int>();
            for (int i= 0; i < 20; i++)
            {
                Listdice.Add(new Dice(6));
            }
            */
            //zadatak 2
            /*
            DiceRoller Roller = new DiceRoller();
            Random RandInstance = new Random();
            List<Dice> Listdice = new List<Dice>();
            IList<int> RollResults = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Listdice.Add(new Dice(6,RandInstance));
            }
            */
            //zadatak 3
            /*
            DiceRoller Roller = new DiceRoller();
            List<Dice> Listdice = new List<Dice>();
            IList<int> RollResults = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Listdice.Add(new Dice(6));
            }
            */
            foreach (Dice die in Listdice)
            {
                Roller.InsertDie(die);
            }
            Roller.RollAllDice();
            RollResults = Roller.GetRollingResults();
            foreach(int roll in RollResults)
            {
                Console.WriteLine(roll);
            }
        }
    }
}
