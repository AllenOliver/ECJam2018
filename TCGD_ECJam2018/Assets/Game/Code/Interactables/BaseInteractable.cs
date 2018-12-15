using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;


public class BaseInteractable :MonoBehaviour
{
    
    #region Properties

    public string InteractableName;
    public string Description;
    public Sprite InteractableImage;

    public Interactable interactable;


    #endregion

    public virtual void Start()
    {
        if (interactable)
        {
            InteractableName = interactable.Name;
            Description = interactable.Description;
            InteractableImage = interactable.Image;
        }
    }

    #region Interacting

    /// <summary>
    /// Sets the global bool for this item.
    /// Pls override
    /// </summary>
    public virtual void SetGlobal()
    {
    }

    /// <summary>
    /// Called when [interact].
    /// Sets global flag and starts UI
    /// </summary>
    public virtual void OnInteract()
    {
        //TODO Interact and do UI stuff
        var ui = FindObjectOfType<UIManager>();
        ui.OpenInteractMenu(interactable);
        SetGlobal();
    }

    #endregion



}
