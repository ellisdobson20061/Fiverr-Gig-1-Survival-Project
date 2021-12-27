using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryVisible : MonoBehaviour
{
    public bool isOpen;
    public GameObject inventory;

    void Start()
    {
        isOpen = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleInventory();
        }
    }

    void ToggleInventory()
    {
        isOpen = !isOpen;
        inventory.SetActive(isOpen);
    }
}
