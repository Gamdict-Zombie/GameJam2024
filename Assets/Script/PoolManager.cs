using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject[] prefabs;

    List<GameObject>[] pools;

    void Awake(){
        pools = new List<GameObject>[prefabs.Length];

        for(int i = 0; i < pools.Length; i++){
            pools[i] = new List<GameObject>();
        }

        Debug.Log(pools.Length);
    }
}
