using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(27.92108f, 0.2570307f, 1.12f);
    private PlayerController playerControllerScript;

    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }
    void SpawnObstacle()
    {
        if(!playerControllerScript.gameOver)
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
       
}
