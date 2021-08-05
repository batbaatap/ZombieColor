using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 7 * Time.deltaTime, 0);
	}

	// void OnCollisionEnter2D(Collision2D other)
	// {
	// 	if(this.gameObject.name == "BulletRed"){
	// 		if(other.gameObject.tag == "BulletBlue"){
	// 			Destroy(this.gameObject);
	// 		}else 
	// 		if(other.gameObject.tag == "BulletGreen"){
	// 			Destroy(this.gameObject);
	// 		}else 
	// 		if(other.gameObject.tag == "BulletPink"){
	// 			Destroy(this.gameObject);
	// 		}else {
	// 			Destroy(this.gameObject);
	// 			Destroy(other.gameObject);
	// 		}	
	// 	}
	// }

	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "ZombieGreen")
		{
			Destroy(other.gameObject);	
		} else {
			Destroy(this.gameObject);
		}
	}
	
}
