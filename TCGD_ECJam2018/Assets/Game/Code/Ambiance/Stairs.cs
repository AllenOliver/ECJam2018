using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    private bool started;
    private void OnTriggerEnter(Collider col)
    {
        var ui = FindObjectOfType<UIManager>();
        switch (col.gameObject.tag)
        {
            case "Player":
                if (!started)
                {
                    StartCoroutine(NoStairs());
                    started = true;
                }
                break;
        }
    }

    /// <summary>
    /// Tells the player to keep looking for clues.
    /// </summary>
    /// <returns></returns>
    IEnumerator NoStairs()
    {
        var ui = FindObjectOfType<UIManager>();
        ui.SetUIOutputText("There is nothing she would want upstairs...");
        yield return new WaitForSeconds(4f);
        ui.ClearPlayerUIText();
        started = false;
    }
}
