using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnVictoms : MonoBehaviour {
    public GameObject Character;
    public Vector3 spawnLocation = new Vector3(0, 2, 0);
	// Use this for initialization
	void Start () {

	}

    public IEnumerator spawn()
    {
        GameObject SpawnLocation = (GameObject)Instantiate(Character, spawnLocation, Quaternion.identity);
        yield return new WaitForSeconds(10);

    }
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(spawn());

	}
}
