using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    protected bool shouldOpen;
    public float openRate = 5f;
    [Header("Value The Door should Rotate to.")]
    public float zValue;

    void Update()
    {
        if (shouldOpen)
        {
            if (gameObject.transform.localRotation.z < 90f)
            {
                transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0f,0f,zValue), Time.deltaTime * openRate);

            }
        }
        else
        {
            if (gameObject.transform.localRotation.z > 0)
            {
                transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0f, 0f, 0f), Time.deltaTime * openRate);

            }
        }
    }
    /// <summary>
    /// Opens this doorS.
    /// </summary>
    public virtual void Open()
    {
        if (gameObject.transform.localRotation == Quaternion.Euler(0f,0f,0f))
        {
            shouldOpen = true;
        }
        else
        {
            shouldOpen = false;
        }
    }


}
