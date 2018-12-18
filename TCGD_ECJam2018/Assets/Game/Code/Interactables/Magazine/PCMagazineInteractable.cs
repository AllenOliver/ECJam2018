using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCMagazineInteractable : BaseInteractable
{
    public override void SetGlobal()
    {
        Globals.PCMagFound = true;
    }
}
