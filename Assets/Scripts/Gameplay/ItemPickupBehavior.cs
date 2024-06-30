using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickupBehavior : MonoBehaviour
{
    [Tooltip("The item this will grant the player once picked up.")]
    [SerializeField]
    private Item _itemData;

    public Item ItemData { get { return _itemData; } }

    /// <summary>
    /// Perform whatever tasks need to be completed upon picking the item up.
    /// </summary>
    public void PickedUp()
    {
        print("Picked up " + _itemData.ItemName);
        Destroy(gameObject);
    }
}
