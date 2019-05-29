using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour {

    public float tapForce = 10;
    public float tiltSmooth = 5;
    public float speed = 3;
    public Text scoretext ;

    public GameObject a0,a1,a2,a3;

    Rigidbody2D rigidbody;
    Quaternion downRotation;
    Quaternion forwardRotation;
	private AudioSource _audioSource;

	public GameObject control;
    public GameObject gameover;

    void Start ()
    {
	    _audioSource = GetComponent<AudioSource>();
		control = GameObject.FindGameObjectWithTag ("controller");
        a0 = GameObject.Find("0");
        a1 = GameObject.Find("1");
        a2 = GameObject.FindGameObjectWithTag("2");
        a3 = GameObject.Find("3");
        print(Controller.die);
        scoretext = GameObject.Find("Text").GetComponent<Text>() ;
        rigidbody = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);
        gameover = GameObject.FindGameObjectWithTag("over");

    }

    void OnCollisionEnter2D(Collision2D obj)
	{
		if (obj.gameObject.tag == "B1col") {
			control.GetComponent<Controller>().cont();
			Destroy (this.gameObject);
            Controller.die = Controller.die + 1;

            if (Controller.die==1)
            {
                a0.gameObject.SetActive(false);
                
            }


            if (Controller.die == 2)
            {
                a1.gameObject.SetActive(false);

            }
            if (Controller.die == 3)
            {
                a2.gameObject.SetActive(false);

            }
           
               
           

        }

		if (obj.gameObject.tag == "v2") {
			control.GetComponent<Controller>().cont();
			print(obj.gameObject.name);
			Destroy (this.gameObject);
            Controller.score += 1;
			speed = Controller.score + 0.5f;
            scoretext.text = "Score : " + Controller.score.ToString() ;
		}
	}
	

    void Update () 
    {

        if (Input.GetKeyUp(KeyCode.Space))
        {
	        _audioSource.Play();
            transform.rotation = forwardRotation;
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);

        }
        transform.position += Vector3.right * speed * Time.deltaTime;
        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);


	}
}
