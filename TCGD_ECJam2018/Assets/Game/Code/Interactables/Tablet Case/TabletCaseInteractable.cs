using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletCaseInteractable : BaseInteractable
{
    public override void SetGlobal()
    {
        Globals.TabletCaseFound = true;
    }
}
