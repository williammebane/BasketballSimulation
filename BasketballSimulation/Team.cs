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
        private Dictionary<int, Player> players;

        public Team(string name)
        {
            this.name = name;
            this.players = new Dictionary<int, Player>();
        }

        public void addPlayer(Player p1)
        {
            int temp_id = p1.getID();
            this.players.Add(temp_id, p1);
        }

        //return True if the team has a player with the given ID
        public bool hasPlayer(int id)
        {
            if (players.ContainsKey(id)) return true;
            return false;
            
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
            nuggets.addPlayer(kenneth);
            nuggets.addPlayer(nikola);
            nuggets.addPlayer(danilo);
            nuggets.addPlayer(gary);
            nuggets.addPlayer(emmanuel);

            int id = kenneth.getID();


            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}
