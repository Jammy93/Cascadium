﻿


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





// this was found at https://www.youtube.com/watch?v=5u56VBP4n1Y&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5&index=47

namespace S3{
public class Player_Health : MonoBehaviour {





	private GameManager_Master gameManagerMaster; 
	private Player_Master playerMaster; 
	public int playerHealth; 
	public Text healthText; 



		void OnEnable(){

			SetInitialReferences ();
			SetUI();
			playerMaster.EventPlayerHealthDeduction += DeductHealth;
			playerMaster.EventPlayerHealthIncrease += IncreaseHealth;
		}


		void OnDisable(){

			playerMaster.EventPlayerHealthDeduction -= DeductHealth;
			playerMaster.EventPlayerHealthIncrease -= IncreaseHealth;

		}




		/*
	void Start () {

			StartCoroutine (TestHealthDeduction ()); 
		
	}

*/
		void SetInitialReferences()
		{
			gameManagerMaster = GameObject.Find ("GameManager").GetComponent<GameManager_Master> (); 
			playerMaster = GetComponent<Player_Master> (); 


		}


		/*
	IEnumerator TestHealthDeduction()
		{
		yield return new WaitForSeconds (4); 
			DeductHealth (100);
		}
*/
 

		void DeductHealth(int healthChange)
		{
			playerHealth -= healthChange; 

			if (playerHealth <= 0) {

				playerHealth = 0;
				gameManagerMaster.CallEventGameOver ();
			}


			SetUI();
		}
		
		void IncreaseHealth(int healthChange)

		{

			playerHealth += healthChange; 

			if (playerHealth > 100) {

				playerHealth = 100; 


			}

			SetUI ();


		}

		void SetUI(){

			if(healthText != null)
			{

				healthText.text = playerHealth.ToString ();

			}



		}
}
}

