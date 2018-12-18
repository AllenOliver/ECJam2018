using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtBookInteractable : BaseInteractable
{
    public override void SetGlobal()
    {
        Globals.ArtBookFound = true;
    }
}
