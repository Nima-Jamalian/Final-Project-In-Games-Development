using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

    public static void SavePlayerDate(Player player)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Path.Combine(Application.persistentDataPath, "PlayerLocalData");
        Debug.Log(path);
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);
        binaryFormatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayerData()
    {
        string path = Path.Combine(Application.persistentDataPath, "PlayerLocalData");
        if (File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = binaryFormatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        } else
        {
            Debug.Log("No Saved File Found.");
            return null;
        }
    }
}
