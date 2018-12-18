
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Interactable",menuName = "Interactable")]
public class Interactable : ScriptableObject
{
    public string Name;
    [TextArea(0,2)]
    public string Description;
    public Sprite Image;
}
