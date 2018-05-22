using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {


	void Start(){

		Cursor.visible = true;
	}



	//Start Game button function
	public void buttonStartGame(){

	 

		//Change scene when clicked
		SceneManager.LoadScene("Cascadium");

	}
}
