using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerScore;
    public string playerName;

    //Player Pref Saving Data Method
    public void SavePref()
    {
        PlayerPrefs.SetInt("Score", playerScore);
        PlayerPrefs.SetString("Name", playerName);
    }

    public void LoadPref()
    {
        playerScore = PlayerPrefs.GetInt("Score");
        playerName = PlayerPrefs.GetString("Name");
    }

    //Loca Data Save System

    public void SaveDate()
    {
        SaveSystem.SavePlayerDate(this);
    }

    public void LoadData()
    {
        PlayerData data = SaveSystem.LoadPlayerData();
        playerScore = data.playerScore;
        playerName = data.playerName;
    }
}
