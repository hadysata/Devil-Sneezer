using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B1spawn : MonoBehaviour {
	public GameObject virous;
	public Vector3 spawnLocation = new Vector3(28.6f, -14.9f, -26.65123f);
	public bool spawns = false;
	//  public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		GameObject SpawnLocation = (GameObject)Instantiate(virous, spawnLocation, Quaternion.identity);

	}

 public	void respone() {
		GameObject SpawnLocation = (GameObject)Instantiate(virous, spawnLocation, Quaternion.identity);
	}

	// IEnumerator down()
	// {
	//  yield return new WaitForSeconds(2);
	//  (GameObject.FindGameObjectWithTag("virous")).transform.position += Vector3.up * (speed * 5) * Time.deltaTime;

	// }

	// Update is called once per frame
	void Update () {

		if (spawns == true) {
			GameObject SpawnLocation = (GameObject)Instantiate(virous, spawnLocation, Quaternion.identity);
		}

		// if (Input.GetKey(KeyCode.W))
		// {
		//  (GameObject.FindGameObjectWithTag("virous")).transform.position += Vector3.up * (speed * 5) * Time.deltaTime;

		// virous.transform.position += Vector3.up * speed * Time.deltaTime;

		// }

	}
}
