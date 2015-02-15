using UnityEngine;
using System.Collections;

public class movetank : MonoBehaviour {
	public float rotationspeed = 8.5f;
	public float movespeed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * movespeed);
		}
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.Translate(-Vector3.forward * movespeed);	
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Rotate(-Vector3.up * rotationspeed);	
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Rotate(Vector3.up * rotationspeed);	
		}


	}
}
