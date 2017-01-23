using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballSimulation
{
    class Team
    {
        private string name;
        private HashSet<Player> players;

        public Team(string name)
        {
            this.name = name;
            this.players = new HashSet<Player>();
        }

        public void addPlayer(Player p1)
        {
            this.players.Add(p1);
        }

        public static void Main(string[] args)
        {
            // this method only used for testing
            Team nuggets = new Team("Nuggets");
            Player kenneth = new Player("Kenneth Faried");
            Player nikola = new Player("Nikola Jokic");
            Player danilo = new Player("Danilo Gallinari");
            Player gary = new Player("Gary Harris");
            Player emmanuel = new Player("Emmanuel Mudiay");

            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}
