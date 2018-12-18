using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotobookInteractable : BaseInteractable
{
    public override void SetGlobal()
    {
        Globals.DrawingBookFound = true;
    }
}
