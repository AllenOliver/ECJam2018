using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextbookInteractable : BaseInteractable
{
    public override void SetGlobal () 
    {
        Globals.TextbookFound = true;
    }
}
