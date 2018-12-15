
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Interactable",menuName = "Interactable")]
public class Interactable : ScriptableObject
{
    public string Name;
    public string Description;
    public Sprite Image;
}
