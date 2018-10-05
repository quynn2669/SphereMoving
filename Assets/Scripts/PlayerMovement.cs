﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

	// Use this for initialization
	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewaysForce = 1000f;
	void FixedUpdate() 
	{
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);
		
		if(Input.GetKey("d")) 
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
		}

		if(Input.GetKey("a")) 
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
		}
	}
}
