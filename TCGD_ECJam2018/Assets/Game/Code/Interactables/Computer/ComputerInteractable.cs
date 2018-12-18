using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerInteractable : BaseInteractable
{
    public override void SetGlobal()
    {
        Globals.ComputerFound = true;
    }
}
