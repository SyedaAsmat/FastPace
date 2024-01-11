using System;
using System.Collections.Generic;
using System.Linq;

namespace FastPace
{
    public class oneDayTeam : ITeam
    {
        private List<Player> _players;
        public oneDayTeam()
        {
            _players = new List<Player>();
        }
        public void Add(Player player)
        {
            if (_players.Count < 11)
            {
                _players.Add(player);
                Console.WriteLine("Player is added successfully");
            }
            else
            {
                Console.WriteLine("Team is full");
            }
        }
        public void Remove(int playerId)
        {
            Player playerToRemove = _players.FirstOrDefault(p => p.PlayerId == playerId);

            if (playerToRemove != null)
            {
                _players.Remove(playerToRemove);
                Console.WriteLine("Player is removed successfully");
            }
            else
            {
                Console.WriteLine("Player not found");
            }
        }
        public Player GetPlayerById(int playerId)
        {
            Player player = _players.FirstOrDefault(p => p.PlayerId == playerId);

            if (player != null)
            {
                Console.WriteLine($"{player.PlayerId} {player.Name} {player.Age}");
            }
            else
            {
                Console.WriteLine("Player not found");
            }

            return player;
        }
        public Player GetPlayerByName(string playerName)
        {
            Player player = _players.FirstOrDefault(p => p.Name == playerName);

            if (player != null)
            {
                Console.WriteLine($"{player.PlayerId} {player.Name} {player.Age}");
            }
            else
            {
                Console.WriteLine("Player not found");
            }

            return player;
        }
        public List<Player> GetAllPlayers()
        {
            foreach (Player player in _players)
            {
                Console.WriteLine($"{player.PlayerId} {player.Name} {player.Age}");
            }
            return _players;
        }
    }
}