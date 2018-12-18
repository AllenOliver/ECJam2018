using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages UI elements and Logic
/// </summary>
public class UIManager : MonoBehaviour
{

    #region Properties

    public Text HoverUiText;
    public Text PlayerOutputText;


    public Text InteractableName;
    public Text InteractableDesc;
    public Image InteractableImage;
    public GameObject InteractableMenu;
    public GameObject FadePanel;

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
    /// Sets the player output text.
    /// </summary>
    /// <param name="interactable">The interactable.</param>
    public void SetUIOutputText(string text)
    {
        StartCoroutine(TypeText(text, .08f));
    }

    /// <summary>
    /// Clears the UI text.
    /// </summary>
    public void ClearUIText()
    {
        HoverUiText.text = "";
    }

    /// <summary>
    /// Clears the UI text.
    /// </summary>
    public void ClearPlayerUIText()
    {
        PlayerOutputText.text = "";
    }

    /// <summary>
    /// Clears all ui.
    /// </summary>
    public void ClearAll()
    {
        PlayerOutputText.text = "";
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

    #region Fading

    /// <summary>
    /// Fades in screen.
    /// </summary>
    public void fadeIn()
    {
       var anim = FadePanel.GetComponent<Animator>();
        anim.SetTrigger("FadeIn");
    }
    /// <summary>
    /// Fades out screen.
    /// </summary>
    public void fadeOut()
    {
        var anim = FadePanel.GetComponent<Animator>();
        anim.SetTrigger("FadeOut");
    }

    #endregion

    IEnumerator TypeText(string text, float speed)
    {
        foreach (var cha in text)
        {
            PlayerOutputText.text += cha;
            yield return new WaitForSeconds(speed);
        }
    }
}
