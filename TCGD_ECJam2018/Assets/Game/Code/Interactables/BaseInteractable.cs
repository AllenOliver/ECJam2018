using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BaseInteractable :MonoBehaviour
{
    public string InteractableName;
    public string Description;
    public Image Image;

    #region Interacting

    /// <summary>
    /// Sets the global bool for this item.
    /// Pls override
    /// </summary>
    public virtual void SetGlobal(bool valueToSet)
    {
        valueToSet = true;
    }

    /// <summary>
    /// Called when [interact].
    /// Sets global flag and starts UI
    /// </summary>
    public virtual void OnInteract()
    {
        //TODO Interact and do UI stuff
        SetGlobal(Globals.gameStarted);
        Save.SaveGame();

    }

    #endregion

    #region To String Functions

    /// <summary>
    /// Called when [RayCastHit].
    /// </summary>
    /// <returns>A Press to interact prompt</returns>
    public virtual string OnHit()
    {
        return String.Format("Press E to Interact with {0}.",InteractableName);
    }

    #endregion


}
