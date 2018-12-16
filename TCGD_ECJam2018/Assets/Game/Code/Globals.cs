using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals 
{

    #region Public Game Vars
    public static bool gameStarted;
    public static bool CubeFound;

    #endregion

    /// <summary>
    /// Returns the globals.
    /// </summary>
    /// <returns>A list of global bools.</returns>
    public static List<bool> returnGlobals()
    {
        var bools = new List<bool>();
        bools.Add(gameStarted);

        return bools;
    }
}
