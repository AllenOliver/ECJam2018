using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class UIManager : MonoBehaviour
{
    public Text HoverUiText;

    public Text InteractableName;
    public Text InteractableDesc;
    public Image InteractableImage;
    public GameObject InteractableMenu;

    #region UI Updates

    public void SetUIText(Interactable interactable)
    {
        HoverUiText.text = String.Format("Press E to interact with {0}.", interactable.Name);
    }

    public void ClearUIText()
    {
        HoverUiText.text = "";
    }
    #endregion

    #region InteractMenu

    /// <summary>
    /// Opens the interact menu.
    /// </summary>
    /// <param name="interactable">The interactable.</param>
    public void OpenInteractMenu(Interactable interactable)
    {
        if (!InteractableMenu.activeInHierarchy)
        {
            InteractableName.text = interactable.Name;
            InteractableDesc.text = interactable.Description;
            InteractableImage.sprite = interactable.Image;
            if (!InteractableMenu.activeInHierarchy)
                InteractableMenu.SetActive(true);
        }
        else
        {
            if (InteractableMenu.activeInHierarchy)
                InteractableMenu.SetActive(false);
        }
    }



    #endregion

}
