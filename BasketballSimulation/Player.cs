using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BasketballSimulation
{
    public class Player
    {
        private String firstName;
        private String lastName;
        int id;
        

        public Player(String name)
        {
            String[] parsed = name.Split(' ');
            this.firstName = parsed[0];
            this.lastName = parsed[1];
            setID();
            updateStats();
        }

        // return true if setting the ID was successful
        private void setID()
        {
            Task<int> temp_id = API.getPlayerID(firstName, lastName);
            this.id = temp_id.Result;
        }

        public void updateStats()
        {
            
        }

        public int getID()
        {
            return this.id;
        }

        public string getName()
        {
            return this.firstName + " " + lastName;
        }
        
    }
}
