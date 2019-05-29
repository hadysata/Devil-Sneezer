using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

	public GameObject cam;
	public GameObject man;
    public GameObject vc;
    public Text txt;
    public GameObject img;

    public Animator ch;


	// Use this for initialization
	void Start () {
	}

	IEnumerator pause() {
		yield return new WaitForSeconds(2);
		man.GetComponent<Man_Walk> ().GameStart = true;
        vc.GetComponent<Man_Walk>().GameStart = true;

	}
	// Update is called once per frame
	void Update () {
     //   ch.SetBool("IsRun", false);

		if (Input.GetKeyDown (KeyCode.Space)) {
			cam.GetComponent<CFC> ().GameStart = true;
            txt.gameObject.SetActive(true);
            img.gameObject.SetActive(true);

            StartCoroutine(pause());

		}
	}
}
