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
        private int id;

        private Dictionary<int, Player> players;

        public Team(string name)
        {
            this.name = name;
            this.players = new Dictionary<int, Player>();
            setID();
        }

        private void setID()
        {
            // Don't have to add this. everywhere but I like explicitly making it clear I'm altering current instance
            this.id = API.getTeamID(this.name).Result; 
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

        public string getName()
        {
            return this.name;
        }

        public int getID()
        {
            return this.id;
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



            
           

            Console.WriteLine("success");
            Console.WriteLine(nuggets.getID());
            Console.ReadLine();
        }

    }
}
