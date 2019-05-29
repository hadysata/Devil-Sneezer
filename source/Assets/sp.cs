using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "spp")
        {
            this.transform.position = new Vector3(-29.88f, 16.94531f, -12.78f);
        }

    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
        }
	}
}
