using System;
using System.Collections.Generic;
using System.Text;

namespace Dizaj_u_objektno_orijentiranom_sustavu_LV2
{
    class DiceRoller
    {
        private List<Dice> dice;
        private List<int> resultForEachRoll;
        private ConsoleLogger Consolelog;
        private FileLogger Filelog;
        public DiceRoller()
        {
            this.dice = new List<Dice>();
            this.resultForEachRoll = new List<int>();
            this.Filelog = new FileLogger();
            this.Consolelog = new ConsoleLogger();
        }
        public void InsertDie(Dice die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Dice die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        // 1,2 i 3 zadatak
        /*
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
           this.resultForEachRoll
           );
        }
        */
        //4 zadatak
        /*
        public void GetRollResult()
        {
            foreach (int result in this.resultForEachRoll)
            {
                Consolelog.log(result.ToString());
            }
        }
        public void GetRollResult(string Filepath)
        {
            foreach (int result in this.resultForEachRoll)
            {
                Consolelog.log(result.ToString());
            }
        }
        */
        public int DiceCount
        {
            get { return dice.Count; }
        }
    }
}
