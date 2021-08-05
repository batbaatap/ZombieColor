using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPoint : MonoBehaviour {

	public GameObject shape1;
	public GameObject shape2;
	public GameObject shape3;
	public GameObject shape4;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position == shape1.transform.position)
		{
			gameObject.tag = "okay";
		}else
		if(transform.position == shape2.transform.position)
		{
			gameObject.tag = "okay";
		}else 
		if(transform.position == shape3.transform.position)
		{
			gameObject.tag = "okay";
		}else
		if(transform.position == shape4.transform.position)
		{
			gameObject.tag = "okay";
		}else{
			gameObject.tag = "findme";
		}		
	}

}
