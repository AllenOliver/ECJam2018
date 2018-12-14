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

    #region TESTING

    public Text ui;
    #endregion
    void Update()
    {
        Interact();
    }

    void Interact()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * RayLength, Color.red, .5f);

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out ray, RayLength))
        {
            if (ray.collider.tag == "Interactable")
            {
                //TODO UI updates
                ui.text = "Hit!";

            }
            else
            {
                ui.text = "";
            }
        }
    }


}
