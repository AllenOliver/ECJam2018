using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator anim;

    void Start()
    {
        
    }
    /// <summary>
    /// Opens this doorS.
    /// </summary>
    public void Open()
    {
        if (gameObject.transform.localRotation == Quaternion.Euler(0f,0f,0f))
        {
            anim.SetTrigger("Open");
        }
        else
        {
            anim.SetTrigger("Close");

        }
    }


}
