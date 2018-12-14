using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class Save 
{
    static string fileName = "Data.tcgd";

    #region Public Static Functions

    /// <summary>
    /// Saves the Game.
    /// </summary>
    public static void SaveGame()
    {

        BinaryFormatter bf = new BinaryFormatter();
        string path = string.Format("{0}/{1}", Application.persistentDataPath, fileName);
        FileStream fs = new FileStream(path, FileMode.Create);
        bf.Serialize(fs, GetSaveData());
        fs.Close();
    }


    /// <summary>
    /// Loads the game.
    /// </summary>
    /// <returns>Game Data</returns>
    public static SaveGameData LoadGame()
    {
        string path = string.Format("{0}/{1}", Application.persistentDataPath, fileName);

        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);

            SaveGameData d = bf.Deserialize(fs) as SaveGameData;
            return d;
        }
        else
        {
            return null;

        }


    }

    #endregion

    #region Private Functions

    /// <summary>
    /// Gets and creates the save data from globals.
    /// </summary>
    /// <returns>A save data object to save.</returns>
    private static SaveGameData GetSaveData()
    {
        SaveGameData d = new SaveGameData();

        #region Save Variables
        d.StartedGame = Globals.gameStarted;
        #endregion

        return d;
    } 

    #endregion

}
