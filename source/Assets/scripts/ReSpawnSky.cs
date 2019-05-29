using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawnSky : MonoBehaviour {

	public GameObject Character;
	public Vector3 spawnLocation;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter2D(Collision2D obj)
	{
		if (obj.gameObject.tag == "fr")
		{
			//Destroy(obj.gameObject);
			GameObject SpawnLocation = (GameObject)Instantiate(Character, spawnLocation, Quaternion.identity);

		}
	}
	
	// Update is called once per frame
	void Update () {
		spawnLocation = GameObject.Find("Main Camera").transform.position * 2;

	}
}
