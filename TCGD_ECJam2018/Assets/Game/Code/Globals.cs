using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals 
{

    #region Public Game Vars
    public static bool gameStarted;
    public static bool VideoCardFound;
    public static bool PCMagFound;
    public static bool CameraFound;



    #endregion

    /// <summary>
    /// Returns the globals.
    /// </summary>
    /// <returns>A list of global bools.</returns>
    public static List<bool> returnGlobals()
    {
        var bools = new List<bool>();
        bools.Add(gameStarted);
        bools.Add(VideoCardFound);
        bools.Add(PCMagFound);
        bools.Add(CameraFound);

        return bools;
    }
}
