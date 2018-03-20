using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField]
    GameObject objectToSpawn;
    [SerializeField]
    Vector3 offSet;

    public void Spawn()
    {
        Instantiate(objectToSpawn,transform.position + offSet, transform.rotation);
    }
}
