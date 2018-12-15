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
        StartCoroutine(OpenMenu(interactable));
    }

    /// <summary>
    /// Opens the menu.
    /// </summary>
    /// <param name="interactable">The interactable.</param>
    /// <returns></returns>
    IEnumerator OpenMenu(Interactable interactable)
    {
        var player = FindObjectOfType<FirstPersonController>();

        var oldX = player.m_MouseLook.YSensitivity;
        var oldY = player.m_MouseLook.YSensitivity;
        var oldWalk = player.m_WalkSpeed;

        player.m_MouseLook.XSensitivity = 0;
        player.m_MouseLook.YSensitivity = 0;
        player.m_WalkSpeed = 0;

        InteractableName.text = interactable.Name;
        InteractableDesc.text = interactable.Description;
        InteractableImage.sprite = interactable.Image;
        if (!InteractableMenu.activeInHierarchy)
            InteractableMenu.SetActive(true);
        yield return new WaitUntil((() => Input.anyKeyDown));

        player.m_WalkSpeed = oldWalk;
        player.m_MouseLook.XSensitivity = oldX;
        player.m_MouseLook.YSensitivity = oldY;

        if (InteractableMenu.activeInHierarchy)
            InteractableMenu.SetActive(true);
    } 

    #endregion

}
