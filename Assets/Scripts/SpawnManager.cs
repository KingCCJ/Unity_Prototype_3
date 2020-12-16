using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPOS = new Vector3(25, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstaclePrefab, spawnPOS, obstaclePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
