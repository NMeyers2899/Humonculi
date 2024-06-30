using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    /// <summary>
    /// The ID of the item in reference to other items.
    /// </summary>
    public int ID;

    /// <summary>
    /// The name of the item.
    /// </summary>
    public string ItemName;

    /// <summary>
    /// The icon that will appear for the items in the inventory.
    /// </summary>
    public Texture2D Icon;
}
