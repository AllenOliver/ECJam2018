using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class PlayerInteract : MonoBehaviour
{
    public int RayLength;
    private RaycastHit ray;
    private UIManager ui;

    void Start()
    {
        ui = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        Interact();
    }

    void Interact()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out ray, RayLength))
        {
            if (ray.collider.tag == "Interactable")
            {
                ui.SetUIText(ray.collider.gameObject.GetComponent<BaseInteractable>().interactable);
                

                //TODO UI updates
                if (Input.GetButtonDown("Interact"))
                {
                    //TODO Interact and stop character
                    ray.collider.gameObject.GetComponent<BaseInteractable>().OnInteract(true);
                    ui.ClearUIText();
                    
                }
                else
                {


                }

            }
            else
            {
                ui.ClearUIText();
            }

        }
        else
        {
            ui.ClearUIText();
        }

    }


}
