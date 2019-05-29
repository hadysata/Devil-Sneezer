using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

	public Transform canves;
    public Transform canves2;

    private AudioSource _audioSource;

	private void Start()
	{
		_audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

        if(Controller.die== 4)
        {
            GameOver();
        }

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (canves.gameObject.activeInHierarchy == false)
			{
				canves.gameObject.SetActive(true);
				Time.timeScale = 0;
				_audioSource.Stop();
				
			}
			else
			{
				canves.gameObject.SetActive(false);
				Time.timeScale = 1;
				_audioSource.Play();
			}
		}
	}

    void GameOver()
    {
        if (canves2.gameObject.activeInHierarchy == false)
        {
            canves2.gameObject.SetActive(true);
            Time.timeScale = 0;
            _audioSource.Stop();

        }
    }

	public void ResumeGame()
	{
		canves.gameObject.SetActive(false);
		Time.timeScale = 1;
	}

	public void MainMenu()
	{
        canves2.gameObject.SetActive(false);
        Controller.die = 0;
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
        canves2.gameObject.SetActive(false);

    }

    public void ExitGame()
	{
		Application.Quit();
	}
}
