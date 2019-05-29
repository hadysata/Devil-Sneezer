using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {
    public string Tag_Name;
    public GameObject Character;
    public Vector3 spawnLocation;

	// Use this for initialization
	void Start () {
	}

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == Tag_Name)     
        {
            Destroy(obj.gameObject);
            GameObject SpawnLocation = (GameObject)Instantiate(Character, Character.transform.position + spawnLocation , Quaternion.identity);

        }
    }
	// Update is called once per frame
	void Update () {
		spawnLocation = GameObject.Find ("man").transform.position + new Vector3(18,0,0)   ;
	}
}
