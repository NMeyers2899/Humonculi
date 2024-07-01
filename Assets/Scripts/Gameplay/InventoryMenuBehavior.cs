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

    private void OnEnable()
    {
        for (int i = 0; i < _playerInventory.Inventory.Length; i++)
        {
            if(_playerInventory.Inventory[i])
            {
                _itemButtons[i].GetComponentInChildren<Text>().text = _playerInventory.Inventory[i].ItemName;

                _itemButtons[i].GetComponentInChildren<Image>().sprite = _playerInventory.Inventory[i].Icon;
            }
            else
            {
                _itemButtons[i].GetComponentInChildren<Text>().text = "";
            }
        } 
    }
}
