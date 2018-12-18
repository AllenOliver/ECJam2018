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
    public static bool ComputerFound;
    public static bool CalendarFound;
    public static bool PhotoBookFound;
    public static bool DrawingFound;
    public static bool TabletCaseFound;
    public static bool TextbookFound;



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
        bools.Add(ComputerFound);
        bools.Add(CalendarFound);
        bools.Add(PhotoBookFound);
        bools.Add(DrawingFound);
        bools.Add(TabletCaseFound);
        bools.Add(TextbookFound);

        return bools;
    }
}
