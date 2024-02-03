using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        private int value;

        public int Value { get { return value; } set { this.value = value; } }

        public Coin(string description, int score, int value) : base(description, score)
        {
            this.value = value;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += value;
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }

        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}
