using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractable : BaseInteractable
{
    public override void SetGlobal()
    {
        Globals.CubeFound = true;
    }
}
