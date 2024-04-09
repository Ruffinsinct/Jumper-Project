using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float delayStart = 1.0f;
    private float repeatInt = 1.6f;
    private playerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<playerController>();
        InvokeRepeating("SpawnObstacle", delayStart, repeatInt); 
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObstacle() 
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }
}
