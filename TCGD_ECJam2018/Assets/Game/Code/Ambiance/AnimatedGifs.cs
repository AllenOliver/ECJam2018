using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Plays an animated gif on a face.
/// </summary>
public class AnimatedGifs : MonoBehaviour
{

    #region Properties

    [SerializeField] private Texture2D[] frames;
    [SerializeField] private float fps = 10.0f;
    private Material mat; 

    #endregion

    #region Unity Functions

    void Start()
    {
        mat = GetComponent<Renderer>().material;

    }

    void Update()
    {
        int index = (int)(Time.time * fps);
        index = index % frames.Length;
        mat.mainTexture = frames[index];
    } 

    #endregion
}
