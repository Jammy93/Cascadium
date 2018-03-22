using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMouseLook : MonoBehaviour {

	//script is found also on Holistic3d found on YouTube
	// https://www.youtube.com/watch?v=blO039OzUZc



	Vector2 mouseLook;  //total movement tracker
	Vector2 smoothV;   // slows or smooths the camera when moving
	public float sensitivity = 5.0f;   //how much mouse move speed for character
	public float smoothing = 2.0f;  // how much smoothing you need

	GameObject character;

	void Start()
	{
		//character is set to the parent gameobject, the cameras parent
		character = this.transform.parent.gameObject;
	}


	// Update is called once per frame
	void Update () {

		var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));


		//smooths the camera between two points rather than having a snapping effect
		md = Vector2.Scale (md, new Vector2 (sensitivity * smoothing, sensitivity * smoothing));
		//
		smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing); 
		smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing); 

		mouseLook += smoothV;


		//allows the translation to mouselook y to ints local raotion to the right axis
		transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
		//this is rotation of the characters up movement
		character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
	}
}
