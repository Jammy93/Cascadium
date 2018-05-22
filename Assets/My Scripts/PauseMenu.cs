using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	//This code was found at https://www.youtube.com/watch?v=JivuXdrIHK0
	//The Minimap was also found at https://www.youtube.com/watch?v=28JTTXqMvOU

	public static bool GameIsPaused = false; 
	public GameObject pauseMenuUI;



	void Update() {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameIsPaused) {
				Resume ();
			} else {
				Pause ();
			}
		}




	}

	void Resume()
	{
		pauseMenuUI.SetActive (false); 
		Time.timeScale = 1f;
		GameIsPaused = false;
	

	}

	void Pause()
	{
		pauseMenuUI.SetActive (true); 
		Time.timeScale = 0f;
		GameIsPaused = true;

	}




}
