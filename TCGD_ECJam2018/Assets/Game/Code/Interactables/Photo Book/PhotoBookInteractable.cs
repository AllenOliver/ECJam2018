using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoBookInteractable : BaseInteractable
{
    public override void SetGlobal () 
    {
        Globals.PhotoBookFound = true;
    }
}
