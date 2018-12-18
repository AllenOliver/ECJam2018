using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarInteractable : BaseInteractable
{
    public override void SetGlobal () 
    {
        Globals.CalendarFound = true;
    }
}
