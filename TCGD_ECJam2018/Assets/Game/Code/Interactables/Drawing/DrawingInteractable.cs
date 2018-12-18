using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingInteractable : BaseInteractable
{
    public override void SetGlobal() 
    {
        Globals.DrawingFound = true;
    }
}
