using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [DoNotSerialize] public static List<GameObject> inv = new List<GameObject>();
}
