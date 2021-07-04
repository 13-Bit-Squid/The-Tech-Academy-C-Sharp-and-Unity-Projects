using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //abstract methods are required in any inheritor classes.

        public virtual void ListPlayers() //allows you to override method but still use it's logic.
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
