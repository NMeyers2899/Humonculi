using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    [Tooltip("The ID of the item in reference to other items.")]
    public int ID;

    [Tooltip("The name of the item.")]
    public string ItemName;

    [Tooltip("The icon that will appear for the items in the inventory.")]
    public Sprite Icon;


}
