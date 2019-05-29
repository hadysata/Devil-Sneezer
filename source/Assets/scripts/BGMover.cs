using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMover : MonoBehaviour {

	public GameObject BG1, BG2;
	private GameObject F4Mover;


	// Use this for initialization
	void Start ()
	{
		F4Mover = GameObject.FindWithTag("Trigger");
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		float offset = (BG1.GetComponentInChildren<BoxCollider2D>().size.x) * 2;
		if (other.gameObject.CompareTag ("Player")) {
			BG1.transform.position = new Vector3 (BG2.transform.position.x + offset,BG1.transform.position.y,BG1.transform.position.z);
		}

		if (!F4Mover.GetComponent<BoxCollider2D>().enabled)
			F4Mover.GetComponent<BoxCollider2D>().enabled = true;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
