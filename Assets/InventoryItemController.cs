using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    private Item item;

    public Button RemoveButton;

    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);

        Destroy(gameObject);
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
    }

    public void UseItem()
    {
        switch (item.itemType)
        {
            case Item.ItemType.Health:
                PlayerHealth.Instance.ResoreHealth(item.value);
                break;

            case Item.ItemType.Ammo:
                AmmoUI.Instance.InceaseAmmo(item.value);
                break;

            default:
                break;
        }

        RemoveItem();
    }
}