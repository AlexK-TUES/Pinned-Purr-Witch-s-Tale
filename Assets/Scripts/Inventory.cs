using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [DoNotSerialize] public List<GameObject> inv = new List<GameObject>();
}
