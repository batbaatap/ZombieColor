using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie1 : MonoBehaviour {
	public GameObject[] ZombieF;
	public float timeToSpeed = 1;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		// int rr = Random.Range(0,180);
		if(Time.time > timeToSpeed){
			// SpawnZombie();
			int RandomZombie = Random.Range(0, 4);
			Instantiate(ZombieF[RandomZombie], transform.position, Quaternion.identity);
			timeToSpeed = Time.time + 4;	
		}
	}
}
