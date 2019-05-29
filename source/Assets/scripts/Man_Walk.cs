using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man_Walk : MonoBehaviour
{

	public float speed = 3 ;
	public GameObject man;
	public bool Run = true;
	public bool Right = true;
    public bool vcRun ;

	public bool victom;
	public bool GameStart;
	public Animator ch;
    public Animator vc;

  //  public GameObject step;


    public GameObject cam;
	public GameObject b1;

	public GameObject virous;
	public Vector3 spawnLocation = new Vector3(28.6f, -14.9f, -26.65123f);
	private AudioSource audio;

    //public bool spawns = false;

    // public GameObject cam;
    // Use this for initialization
    void Start ()
	{
	audio = GetComponent<AudioSource>();
	}

	void OnCollisionEnter2D(Collision2D obj)
	{
		if (obj.gameObject.tag == "Victom")
		{
			
			b1.gameObject.SetActive(true);

//			(GameObject.FindGameObjectWithTag ("B1")).gameObject.SetActive (true);
			GameObject SpawnLocation = (GameObject)Instantiate(virous, spawnLocation, Quaternion.identity);


            cam.GetComponent<CFC>().offset = new Vector3(0.4f, -0.25f, 0.0f);


          
			Run = false;
			audio.Play();

			Physics2D.IgnoreLayerCollision(8, 9);

		}


        if (obj.gameObject.tag == "Player")
        {
            vc.SetBool("IsRun", false);
            vcRun = false;
            GameStart = false;

        }


	}

	// Update is called once per frame
	void Update () {

        if (vcRun)
        {
            vc.SetBool("IsRun" , true);
        }
        else
        {
            vc.SetBool("IsRun", false);
        }


		if (Run == true) {
			ch.SetBool ("IsRun", true);
            
        } else {
            ch.SetBool("IsRun", false);
           // step.gameObject.SetActive(false);

        }



        if (GameStart == true) {
			
			if (Run && Right) {
              //  man.GetComponentInChildren<AudioSource>().Play();

              //  (GameObject.FindGameObjectWithTag("fr")).GetComponent<AudioSource>().Play();


                man.transform.position += Vector3.right * speed * Time.deltaTime;
			} else if (Run && Right == false) {
				man.transform.position += Vector3.left * speed * Time.deltaTime;
			}
		}
	}
}
