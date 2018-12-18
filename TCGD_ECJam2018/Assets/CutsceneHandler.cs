using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneHandler : MonoBehaviour
{

    public Sprite [] slides;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CutScene");
    }

    IEnumerator CutScene () 
    {
        image.sprite = slides[0];
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.anyKey);
        image.sprite = slides[1];
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.anyKey);
        image.sprite = slides[2];
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.anyKey);
        image.sprite = slides[3];
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.anyKey);
        image.sprite = slides[4];
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.anyKey);
        image.sprite = slides[5];
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.anyKey);
        image.sprite = slides[6];
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.anyKey); 
    }
}
