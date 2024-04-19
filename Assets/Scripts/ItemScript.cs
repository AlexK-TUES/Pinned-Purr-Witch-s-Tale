using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    [SerializeField] private GameObject inv_obj;
    private List<GameObject> inv;

    void Start()
    {
        inv = inv_obj.GetComponent<Inventory>().inv;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(!inv.Contains(gameObject) || !GetComponent<SpriteRenderer>().enabled)
        {
            inv.Add(gameObject);
        }

        GetComponent<SpriteRenderer>().enabled = false;
    }
}
