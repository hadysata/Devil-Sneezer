using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Victom")
        {
            Destroy(obj.gameObject);
        }
    }
   
	// Update is called once per frame
	void Update () {
		
	}
}
