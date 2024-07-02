using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuManagerBehavior : MonoBehaviour
{
    [Tooltip("The inventory menu for the player.")]
    public GameObject InventoryMenu;

    private void Update()
    {
        // If the player presses down I...
        if (Input.GetKeyDown(KeyCode.I))
        {
            // ...open the inventory menu.
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
