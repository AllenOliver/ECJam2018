using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

[XmlRoot("InteractableCollection")]
public class InteractableContainer 
{
    [XmlArray("Interactables")]
    [XmlArrayItem("Interactable")]
    private static List<Interactable> items = new List<Interactable>(10);

    #region LoadingFromXML


    public List<Interactable> LoadFromXML()
    {
        TextAsset xml = Resources.Load<TextAsset>("Interactables");
        XmlSerializer xs = new XmlSerializer(typeof(Interactable));

        StringReader reader = new StringReader(xml.text);
        items = xs.Deserialize(reader) as List<Interactable>;
        reader.Close();
        return items;
    }
    #endregion
}
