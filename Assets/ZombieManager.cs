// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ZombieManager : MonoBehaviour {


// 	public Transform[] Points;

// 	public GameObject ZombieObject;

// 	public float timeBetweenWaves =2f;

// 	private float timeToSpawn = 2f;
// 	// Use this for initialization
// 	void Start () {
		
// 	}
	
// 	// Update is called once per frame
// 	void Update () {
// 		if(Time.time >= timeToSpawn)
// 		{
// 			SpawnZombie();
// 			timeToSpawn = Time.time + timeBetweenWaves;
// 		}
// 	}

// 	internal void SpawnZombie(){
		
// 		int index = Random.Range(0, Points.Length);

// 		for(int i = 0; i < Points.Length; i++)
// 		{
// 			if(index != i)
// 			{
// 				Instantiate(ZombieObject, Points[i].transform.position, Quaternion.identity);
// 			}
// 		}
// 	}
// }
