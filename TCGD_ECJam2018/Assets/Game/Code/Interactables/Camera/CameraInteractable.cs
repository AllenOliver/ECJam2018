using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteractable : BaseInteractable
{
    public override void SetGlobal()
    {
        Globals.CameraFound = true;
    }
}
