using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuManagerBehavior : MonoBehaviour
{
    /// <summary>
    /// The inventory menu for the player.
    /// </summary>
    public GameObject InventoryMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            InventoryMenu.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    /// <summary>
    /// Disables the inventory menu.
    /// </summary>
    public void DisableInventoryMenu()
    {
        InventoryMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
