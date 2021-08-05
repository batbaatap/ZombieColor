using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRed : MonoBehaviour {
	public GameObject Bullet;
	private float timeToSpawn = 1f;

	public GameObject Blue;
	public GameObject Green;
	public GameObject Pink;


	internal GameObject firstPos;
	internal GameObject secondPos;
	internal GameObject thirdPos;
	internal GameObject fourthPos;


	public bool Drag;
	public bool found;

	// Use this for initialization
	void Start () {
		  firstPos =  GameObject.Find("1stPosition");
		  secondPos = GameObject.Find("2ndPosition");
		  thirdPos =  GameObject.Find("3thPosition");
		  fourthPos = GameObject.Find("4thPosition");
	}

	// Update is called once per frame
	void Update () {

		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		if(transform.position.x == Blue.transform.position.x && gameObject.tag == "Gun"){
			print("Red Equal to GunBlue");
			// transform.position = Blue.transform.position;		
			GameObject findPoint = GameObject.FindGameObjectWithTag("findme");
			transform.position = findPoint.transform.position;	

		} else if(transform.position.x == Green.transform.position.x && gameObject.tag == "Gun"){
			print("Equal position same GunGreen");
			GameObject findPoint = GameObject.FindGameObjectWithTag("findme");
			transform.position = findPoint.transform.position;			

		} else if(transform.position.x == Pink.transform.position.x && gameObject.tag == "Gun"){
			print("Equal position same GunPink");
			GameObject findPoint = GameObject.FindGameObjectWithTag("findme");
			transform.position = findPoint.transform.position;	
			

		} else {
			gameObject.tag = "Gun";
		}

		if(Time.time >= timeToSpawn){
			print("Time.time " + Time.time);
			print("timeToSpawn " + timeToSpawn);

			Shoot();
			timeToSpawn = Time.time + 0.3f;
		}

		if (Drag){
			transform.position = mousePos;
			gameObject.tag = "Dropped";
		}
	}

	public void Shoot()
	{
		if(!Drag)
		Instantiate(Bullet, transform.position, Quaternion.identity);
	}

	void OnMouseDown()
	{
		Drag = true;
	}

	void OnMouseUp()
	{
		Drag = false;
		
		if(transform.position.x < -1.35f ){
			transform.position = firstPos.transform.position;

		}else if(-1.35f < transform.position.x && transform.position.x < 0){
			transform.position = secondPos.transform.position;

		}else if(0 < transform.position.x && transform.position.x < 1.22f){
			transform.position = thirdPos.transform.position;

		}else if(1.22f < transform.position.x){
			transform.position = fourthPos.transform.position;
		}
	}

	// void OnCollisionEnter2D(Collision2D other)
	// {
	// 	if(other.gameObject.tag == "GunBlue")
	// 	{
	// 		print("Collision Detected");

	// 		found = true;
			
	// 		transform.position = other.transform.position;
	// 	}
	// }
}
