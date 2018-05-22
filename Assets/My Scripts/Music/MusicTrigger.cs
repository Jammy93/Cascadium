using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour {


	public AudioSource source; 
	public AudioClip clip; 
	private bool isPlayed; 


	public void Awake(){

		source = GetComponent<AudioSource> ();
		isPlayed = false; 

	}


	public void OntriggerEnter(Collider other){

		if (!isPlayed) {
		source.Play ();
		isPlayed = true; 

	}




}
}
