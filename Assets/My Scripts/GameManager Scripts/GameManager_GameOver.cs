using System.Collections;
using System.Collections.Generic;
using UnityEngine;






//this was found at https://www.youtube.com/watch?v=9z7_tlX8OTg&index=41&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5

namespace S3
{


public class GameManager_GameOver : MonoBehaviour {

	
		private GameManager_Master gameManagerMaster;
		public GameObject panelGameOver; 




		void OnEnable()
		{

			SetInitialReferences ();
			gameManagerMaster.GameOverEvent += TurnOnGameOverPanel;


		}


		void OnDisable()
		{

			gameManagerMaster.GameOverEvent -= TurnOnGameOverPanel;

		}


		void SetInitialReferences()
		{

			gameManagerMaster = GetComponent<GameManager_Master> (); 

		}


		void TurnOnGameOverPanel()
		{
			if (panelGameOver != null) {


				panelGameOver.SetActive (true);

			}



		}


}

}