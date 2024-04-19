using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!Inventory.inv.Contains(gameObject))
        {
            Inventory.inv.Add(gameObject);
        }
        foreach (var item in Inventory.inv)
            Debug.Log(item.ToString());

        gameObject.SetActive(false);
    }
}
