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
            if (ray.collider.tag == "Interactable")
            {
                ui.SetUIText(ray.collider.gameObject.GetComponent<BaseInteractable>().interactable);
                
                if (Input.GetButtonDown("Interact"))
                {
                    //TODO Interact and stop character
                    ray.collider.gameObject.GetComponent<BaseInteractable>().OnInteract();
                    ui.ClearUIText();
                }
            }
            else
            {
                ui.ClearUIText();
                ui.InteractableMenu.SetActive(false);
            }

        }
        else
        {
            ui.ClearUIText();
        }

    }
}
