﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sproner : MonoBehaviour {


	// add a gameobject to the inspector
	// that we can access in this script
	public GameObject go;
	// start spawning after...seconds
	public float StartAfter = 1f;

	public float SpawnFrequency = .5f;

	// Use this for initialization
	void Start () {
		//do something every x seconds
		// 1: what you want to repeat (as a function)
		// 2: after how many seconds do you want to start doing it? 
		// 3: repeat every x seconds
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);
	}
	
	// Update is called once per frame
	void SpawnThing () {
		// first, move the spawner
//		transform.position = new Vector3(Random.Range(-5,5), 3, Random.Range(-5,5));




		// to create an object, first use Instantiate function
		// which wants 3 arguments:
		// 1: the object you will create
		// 2: where to create that object
		// 3: at what rotation
		Instantiate (go, transform.position, Quaternion.identity);

		// print the location of the spawner object
		Debug.Log(transform.position);
	}
}
