using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour
{
    [SerializeField] public GameObject obj;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(0, obj.transform.position.y, gameObject.transform.position.z);
    }
}
