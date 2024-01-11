using System.Collections.Generic;

namespace FastPace
{
    public interface ITeam
    {
        void Add(Player player);
        Player GetPlayerById(int playerId);
        void Remove(int playerId);
        Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }
}