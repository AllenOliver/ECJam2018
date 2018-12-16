using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages UI elements and Logic
/// </summary>
public class UIManager : MonoBehaviour
{

    #region Properties

    public Text HoverUiText;

    public Text InteractableName;
    public Text InteractableDesc;
    public Image InteractableImage;
    public GameObject InteractableMenu;

    #endregion

    #region UI Updates

    /// <summary>
    /// Sets the UI text.
    /// </summary>
    /// <param name="interactable">The interactable.</param>
    public void SetUIText(Interactable interactable)
    {
        HoverUiText.text = String.Format("Press E to interact with {0}.", interactable.Name);
    }

    /// <summary>
    /// Clears the UI text.
    /// </summary>
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
