using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public GameObject player;
	public GameObject cam1;
	//public GameObject cam2;
    public GameObject vc;
    public static int score = 0;
    public static int die = 0;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyDown (KeyCode.Tab)) {
//player.GetComponent<Man_Walk> ().Run = true;
		//	(GameObject.FindGameObjectWithTag ("Victom")).GetComponent<Man_Walk> ().Run = true;
         //   (GameObject.FindGameObjectWithTag("Victom")).GetComponent<Man_Walk>().vcRun = true;
         //   (GameObject.FindGameObjectWithTag("Victom")).GetComponent<Man_Walk>().GameStart = true;

		//	Destroy(GameObject.FindGameObjectWithTag ("B1"));
		//	cam1.GetComponent<CFC> ().offset = new Vector3(0.4f , 0.23f , 0.0f);
		//	cam2.gameObject.SetActive(false);

	//	}
	}


	public void cont () {
			player.GetComponent<Man_Walk> ().Run = true;
			(GameObject.FindGameObjectWithTag ("Victom")).GetComponent<Man_Walk> ().Run = true;
			(GameObject.FindGameObjectWithTag("Victom")).GetComponent<Man_Walk>().vcRun = true;
			(GameObject.FindGameObjectWithTag("Victom")).GetComponent<Man_Walk>().GameStart = true;

			Destroy(GameObject.FindGameObjectWithTag ("B1"));
			cam1.GetComponent<CFC> ().offset = new Vector3(0.4f , 0.23f , 0.0f);
			//cam2.gameObject.SetActive(false);


	}

}
