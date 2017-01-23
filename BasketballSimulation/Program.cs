using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballSimulation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter player name: ");
            String name = Console.ReadLine();
            Player p1 = new Player(name);
            Console.ReadLine();
        }

    }
}
