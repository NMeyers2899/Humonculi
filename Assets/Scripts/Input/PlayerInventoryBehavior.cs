using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryBehavior : MonoBehaviour
{
    [Tooltip("The inventory for the player.")]
    [SerializeField]
    private Item[] _inventory = new Item[20];

    public Item[] Inventory { get { return _inventory; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
