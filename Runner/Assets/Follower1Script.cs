﻿using UnityEngine;
using System.Collections;

public class Follower1Script : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt (target);
		transform.Translate(Vector3.forward*Time.deltaTime*3f);
	}
}
