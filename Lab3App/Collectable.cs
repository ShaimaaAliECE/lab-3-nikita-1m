using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        private string description;
        private CollectionBoard board;

        public CollectionBoard Board { get { return board; } set { board = value; } }
        public string Description { get { return description; } set { description = value; } }

        // Constructor
        public Collectable(string description)
        {
            this.description = description;
        }

        // Adds item to the collection board
        public virtual void AddMe(List <Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine($"{description} Collected, Congrats!!!");
        }

        public abstract void Display();
    }
}
