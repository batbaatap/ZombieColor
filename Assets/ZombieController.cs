using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour {
	public float timeBetweenWaves =1f;
	public GameObject EnemyValue;
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {

		transform.Translate(0, -1.5f*Time.deltaTime, 0);
		
		// transform.Translate(0, -1 * Time.deltaTime, 0);

		// if(Time.time > colorTime){

			// print(Time.time);

			// int index = Random.Range(0,4);

			// if(index == 1) {
			// 	SpriteRenderer renderer = GetComponent<SpriteRenderer>();
			// 	renderer.color = new Color(0.5f, 0.5f, 0.5f, 1f); // Set to opaque gray
			// }
			// if(index == 2) {
			// 	SpriteRenderer renderer = GetComponent<SpriteRenderer>();
			// 	renderer.color = new Color(0, 0, 1, 1); // Set to opaque gray
			// }
			// if(index == 3) {
			// 	SpriteRenderer renderer = GetComponent<SpriteRenderer>();
			// 	renderer.color = new Color(0, 1, 1, 1); // Set to opaque gray
			// }
			// if(index == 4) {
			// 	SpriteRenderer renderer = GetComponent<SpriteRenderer>();
			// 	renderer.color = new Color(0, 1, 0, 1); // Set to opaque gray
			// }

			// colorTime = Time.time + timeBetweenWaves;
		// }
	}
}
