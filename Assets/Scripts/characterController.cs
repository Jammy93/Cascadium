using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

	//this code is taken from Holistic3d on YouTube
	// https://www.youtube.com/watch?v=blO039OzUZc



	// speed of the character movement
	public float speed = 10.0F; 

	// Use this for initialization
	void Start () {

		// turns off the cursor and locks it away from view when playing 
		Cursor.lockState = CursorLockMode.Locked;
		
	}
	
	// Update is called once per frame
	void Update () {


		//translate movement, which straffes along the x axis and translates it across the z axis
		//translation is the forwards and backwards
		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation); 


		//returns cursor back on to default once the game has finished removing the lock
		if (Input.GetKeyDown ("escape"))
			Cursor.lockState = CursorLockMode.None; 
	}
}
