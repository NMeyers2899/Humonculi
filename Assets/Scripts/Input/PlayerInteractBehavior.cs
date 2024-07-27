using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class PlayerInteractBehavior : MonoBehaviour
{
    private PlayerInventoryBehavior _playerInventory;

    [SerializeField]
    [Tooltip("How far away an object can be picked up from by the player.")]
    private float _interactRange = 10.0f;

    [Tooltip("The object that will be hit with a ray.")]
    private RaycastHit _hit;

    private void Update()
    {
        // Check to see what the player is directly looking at
        Ray ray = Camera.main.ScreenPointToRay(transform.forward);
        
        // Check to see if what the player hits is within range and if it is an item.
        if(Physics.Raycast(ray, out _hit) && Vector3.Distance(transform.position, _hit.transform.position) <= _interactRange && _hit.transform.GetComponent<ItemPickupBehavior>())
        {
            // Check to see if the item is an item.
            ItemPickupBehavior newItem = _hit.transform.GetComponent<ItemPickupBehavior>();
            
            // If the player left clicks...
            if (Input.GetMouseButtonDown(0) && newItem)
            {
                _playerInventory.Inventory[_playerInventory.Inventory.Length] = newItem.ItemData;
                newItem.PickedUp();
            }
                
        }
    }
}
