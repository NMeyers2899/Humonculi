using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenuBehavior : MonoBehaviour
{
    [Tooltip("Reference to the player's inventory.")]
    [SerializeField]
    private PlayerInventoryBehavior _playerInventory;

    [Tooltip("The buttons that will reference the items in the player's inventory.")]
    [SerializeField]
    private Button[] _itemButtons = new Button[20];

    [Tooltip("The icon that will be used for empty item slots.")]
    [SerializeField]
    private Sprite _emptyIcon;

    private void OnEnable()
    {
        // Check through each item in the player's inventory.
        for (int i = 0; i < _playerInventory.Inventory.Length; i++)
        {
            // Represents the text and icons of the inventory slots.
            Text text = _itemButtons[i].GetComponentInChildren<Text>(); 
            Image icon = _itemButtons[i].GetComponentInChildren<Image>();

            // If spot "i" in the inventory has an item...
            if(_playerInventory.Inventory[i])
            {
                // ...set the text to match the item's name and the icon to match its given sprite.
                text.text = _playerInventory.Inventory[i].ItemName;

                icon.sprite = _playerInventory.Inventory[i].Icon;
            }
            // If the spot doesn't have an item...
            else
            {
                // ...set the name to be empty and the icon to be the empty one. c
                text.text = "";

                icon.sprite = _emptyIcon;
            }
        } 
    }
}
