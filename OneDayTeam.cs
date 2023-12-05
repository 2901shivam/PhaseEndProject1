using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject1
{
    public class OneDayTeam : ITeam
    {

        private int capacity;

        private List<Player> oneDayTeam;

       

       

        public OneDayTeam() {

            this.capacity = 11;
            this.oneDayTeam = new List<Player>(capacity);


        }
        public  void Add(Player player)
        {
            

            oneDayTeam.Add(player);
           
            Console.WriteLine("Player Add Successfully");

        }

        public void  Remove(int playerId)
        {
           for(int i = 0; i < oneDayTeam.Count; i++)
            {
                if (oneDayTeam[i].PlayerId == playerId)
                {
                    oneDayTeam.RemoveAt(i);
                    Console.WriteLine("Remove Player Details Successfully");
                    break;
                }
            }
        }

        public Player GetPlayerById(int playerId)
        {
          

            foreach(Player player in oneDayTeam)
            {
                if (player.PlayerId == playerId)
                {
                    return player;
                }
            }
            return null;
        }

        public Player GetPlayerByName(string playerName)
        {
          foreach(Player player in oneDayTeam)
            {
                if (player.PlayerName == playerName)
                {
                    return player;
                }
            }
            return null;
        }

        public List<Player> GetAllPlayers()
        {
            
            return oneDayTeam;
        }
    }
}
