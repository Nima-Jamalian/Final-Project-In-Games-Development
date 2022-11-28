using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class PlayerData 
{
    public int playerScore;
    public string playerName;

    public PlayerData(Player player)
    {
        playerScore = player.playerScore;
        playerName = player.playerName;
    }

}
