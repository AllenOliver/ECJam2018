using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class PlayerInteract : MonoBehaviour
{

    #region Properties

    public int RayLength;
    private RaycastHit ray;
    private UIManager ui;
    private bool uiDelay = true;
    
    #endregion

    #region Unity Functions

    void Start()
    {
        ui = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        Interact();
    } 

    #endregion

    /// <summary>
    /// Allows the player to interact using raycasting
    /// </summary>
    void Interact()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out ray, RayLength))
        {
            switch (ray.collider.tag)
            {
                case "Interactable":
                    if (uiDelay)
                    {
                        ui.SetUIText(ray.collider.gameObject.GetComponent<BaseInteractable>().interactable);
                        uiDelay = false;
                        StartCoroutine(setUIDelay());
                    }

                    if (Input.GetButtonDown("Interact"))
                    {
                        //TODO Interact and stop character
                        ray.collider.gameObject.GetComponent<BaseInteractable>().OnInteract();
                        ui.ClearUIText();
                    }

                    break;
                case "Door":
                    if (uiDelay)
                    {
                        ui.HoverUiText.text = "Open / Close";
                        uiDelay = false;
                        StartCoroutine(setUIDelay());
                    }

                    if (Input.GetButtonDown("Interact"))
                    {
                        ray.collider.gameObject.GetComponent<Door>().Open();
                    }
                    break;
                default:
                    ui.ClearUIText();
                    ui.InteractableMenu.SetActive(false);
                    break;

            }

        }
        else
        {
            ui.ClearUIText();
        }

    }

    IEnumerator setUIDelay()
    {
        yield return new WaitForSeconds(1f);
        uiDelay = true;
    }
}
