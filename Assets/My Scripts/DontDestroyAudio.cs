using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour {

	//This code was found at https://www.youtube.com/watch?v=BKCsH8mQ-lM
	//The music used is royalty free and is found at https://www.youtube.com/watch?v=HDXeSjT0_Ek




	void Awake()
	{

		DontDestroyOnLoad (transform.gameObject);

	}






}
		
