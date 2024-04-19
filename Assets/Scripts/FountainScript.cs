using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FountainScript : MonoBehaviour
{
    [SerializeField] private GameObject empty_jar;
    [SerializeField] private GameObject moon_jar;
    private List<GameObject> inv;

    void Start()
    {
        inv = Inventory.inv;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(inv.Contains(empty_jar)){
            GameObject new_moon_jar = (GameObject)GameObject.Instantiate(moon_jar, new Vector3(empty_jar.transform.position.x,empty_jar.transform.position.y,empty_jar.transform.position.z), Quaternion.identity);
            inv.Add(new_moon_jar);
            new_moon_jar.SetActive(false);
            inv.Remove(empty_jar);
            foreach (GameObject go in inv) { Debug.Log(go); }
        }
    }
}
