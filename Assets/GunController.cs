// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GunController : MonoBehaviour {
// 	public GameObject Bullet;
// 	private float timeToSpawn = 1f;
// 	public Vector2 InitialPosition;
// 	public bool Drag;
// 	// Use this for initialization
// 	void Start () {
// 	}
// 	// Update is called once per frame
// 	void Update () {

// 		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

// 		if(Time.time >= timeToSpawn){
// 			print("Time.time " + Time.time);
// 			print("timeToSpawn " + timeToSpawn);

// 			Shoot();
// 			timeToSpawn = Time.time + 3;
// 		}

// 		if(Drag){
// 			transform.position = mousePos;
// 		}
// 	}

// 	public void Shoot()
// 	{
// 		// if(!Drag)
// 		// Instantiate(Bullet, transform.position, Quaternion.identity);
// 	}

// 	void OnMouseDown()
// 	{
// 		Drag = true;
// 	}

// 	void OnMouseUp()
// 	{
// 		Drag = false;

// 		transform.position = InitialPosition;
// 	}

// 	void OnCollisionStay2D(Collision2D other)
// 	{
// 		if(other.gameObject.tag == "Gun")
// 		{
// 			print("Collision Detected");
// 			this.transform.position = other.gameObject.transform.position;
// 		}
// 	}
// }
