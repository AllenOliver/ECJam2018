using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCardInteractable : BaseInteractable
{
    public override void SetGlobal()
    {
        Globals.VideoCardFound = true;
    }
}
