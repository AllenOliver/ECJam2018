using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class FrontDoor : Door
{
    private bool gameCompleted;
    private readonly List<bool> globalValues = Globals.returnGlobals();

    /// <summary>
    /// Opens this door.
    /// </summary>
    public override void Open()
    {
        if (checkForWin())
        {
            if (gameObject.transform.localRotation == Quaternion.Euler(0f, 0f, 0f))
            {
                shouldOpen = true;
            }
            else
            {
                shouldOpen = false;
            } 
        }
    }

    /// <summary>
    /// Checks for win state using globals.
    /// </summary>
    /// <returns></returns>
    bool checkForWin()
    {
        var win = globalValues.All(l => l); //Check for all true using linq. IE: f(l) = l == true
        if (win)
        {
            return true;
        }
        else
        {
            StartCoroutine(KeepPlaying());
            return false;
        }
    }

    /// <summary>
    /// Tells the player to keep looking for clues.
    /// </summary>
    /// <returns></returns>
    IEnumerator KeepPlaying()
    {
        var ui = FindObjectOfType<UIManager>();
        ui.SetUIOutputText("I better keep looking for ideas...", .08f);
        yield return new WaitForSeconds(4f);
        ui.ClearPlayerUIText();
    }
}
