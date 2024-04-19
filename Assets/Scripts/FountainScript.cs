using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FountainScript : MonoBehaviour
{
    [SerializeField] private GameObject inv_obj;
    [SerializeField] private GameObject empty_jar;
    [SerializeField] private GameObject moon_jar;
    private List<GameObject> inv;

    void Start()
    {
        inv = inv_obj.GetComponent<Inventory>().inv;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Here1");
        if(inv.Contains(empty_jar)){
            Debug.Log("Here2");
            GameObject new_moon_jar = (GameObject)GameObject.Instantiate(moon_jar, new Vector3(empty_jar.transform.position.x,empty_jar.transform.position.y,empty_jar.transform.position.z), Quaternion.identity);
            new_moon_jar.GetComponent<SpriteRenderer>().enabled = false;
            Debug.Log("Here3");
            inv.Add(new_moon_jar);
            inv.Remove(empty_jar);
        }
    }
}
