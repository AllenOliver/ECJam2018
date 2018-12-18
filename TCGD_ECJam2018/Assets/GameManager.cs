using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PauseMenu;

    private bool Paused;
    // Start is called before the first frame update
    void Start()
    {
        Paused = false;
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Paused)
            {
                PauseMenu.SetActive(true);
                Paused = true;
            }
            else
            {
                PauseMenu.SetActive(false);
                Paused = false;
            }
        }

        if (PauseMenu.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
