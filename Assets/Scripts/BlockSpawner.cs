﻿using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public Transform[] spawnPoints;

    // public Transform[] spawnPoints2;

    public GameObject blockPrefab;
    public GameObject starPrefab;

    public float spawnTime = 2f;

    public float spawnTimeInterval = 2f;

    // Use this for initialization
    void Update () {

        if (Time.time >= spawnTime)
        {
            SpawnBlocks();
            spawnTime = Time.time + spawnTimeInterval;
            Debug.Log(spawnTime);

        }

	}
	
	// Update is called when Spawn blocks are called (call function)
	void SpawnBlocks () {

        int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++) {
			// do something
			if (randomIndex != i) {
				Instantiate (blockPrefab, spawnPoints [i].position, Quaternion.identity);
			} else {
				Instantiate (starPrefab, spawnPoints [i].position, Quaternion.identity);
			}

            
		}
    }
}
