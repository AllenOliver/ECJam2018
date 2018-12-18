using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

enum WIN_TYPES
{
    TABLET = 0,
    VIDEOCARD,
    CAMERA,
    NULL
}

public class FrontDoor : Door
{
    private bool gameCompleted;
    private readonly List<bool> globalValues = Globals.returnGlobals();
    private WIN_TYPES win = WIN_TYPES.NULL;

    /// <summary>
    /// Opens this door.
    /// </summary>
    public override void Open()
    {

            if (gameObject.transform.localRotation == Quaternion.Euler(0f, 0f, 0f))
            {
                checkForWin();
                switch (win)
                {
                    case WIN_TYPES.VIDEOCARD:
                        StartCoroutine(FadeOut("Video Card Ending"));
                    break;
                    case WIN_TYPES.TABLET:
                        StartCoroutine(FadeOut("Tablet Ending"));
                    break;
                    case WIN_TYPES.CAMERA:
                        StartCoroutine(FadeOut("Camera Ending"));

                    break;
                    default:
                        return;                        
                }
            }
            else
            {
                shouldOpen = false;
            } 

    }

    /// <summary>
    /// Checks for win state using globals.
    /// </summary>
    /// <returns></returns>
    void checkForWin()
    {
        var winG = globalValues.All(l => l); //Check for all true using linq. IE: f(l) = l == true

        if (Globals.PCMagFound && Globals.ComputerFound && Globals.VideoCardFound)
        {
            win = WIN_TYPES.VIDEOCARD;

        }
         if (Globals.CalendarFound && Globals.CameraFound && Globals.PhotoBookFound)
        {
            win = WIN_TYPES.CAMERA;
        }
        if (Globals.DrawingFound && Globals.TextbookFound && Globals.TabletCaseFound)
        {
            win = WIN_TYPES.TABLET;
        }
         if (winG)
        {
            win = WIN_TYPES.VIDEOCARD;
        }
        //else
        //{
        //    win = WIN_TYPES.NULL;
        //    StartCoroutine(KeepPlaying());
            
        //}
    }

    

    /// <summary>
    /// Tells the player to keep looking for clues.
    /// </summary>
    /// <returns></returns>
    IEnumerator KeepPlaying()
    {
        var ui = FindObjectOfType<UIManager>();
        ui.SetUIOutputText("I better keep looking for ideas...");
        yield return new WaitForSeconds(4f);
        ui.ClearPlayerUIText();
    }

    IEnumerator FadeOut(string levelToLoad)
    {
        var ui = FindObjectOfType<UIManager>();
        ui.fadeOut();
        yield return new WaitUntil(()=>ui.FadePanel.GetComponent<Image>().color.a == 1f);
        SceneManager.LoadScene(levelToLoad);

    }
}
