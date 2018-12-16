using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVLight : MonoBehaviour
{

    #region Properties

    private Light tv;
    private float randomizer;

    [SerializeField] private float flickerTime; 

    #endregion

    #region Unity Functions

    void Start()
    {
        InvokeRepeating("RandomizeLight", .1f, flickerTime);
        tv = GetComponent<Light>();
    } 

    #endregion

    /// <summary>
    /// Randomizes the light.
    /// </summary>
    void RandomizeLight()
    {
        tv.intensity = Random.Range(.2f, .7f);
    }
}
