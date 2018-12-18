using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCInteractable : BaseInteractable
{
    public override void SetGlobal()
    {
        Globals.PCFound = true;
    }
}
