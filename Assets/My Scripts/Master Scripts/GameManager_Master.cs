using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this code was found at https://www.youtube.com/watch?v=Pd80uJEfdE4&index=29&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5

namespace S3
{

public class GameManager_Master : MonoBehaviour {





	public delegate void GameManagerEventHandler(); 
	public event GameManagerEventHandler MenuToggleEvent; 
	public event GameManagerEventHandler GameOverEvent; 
	public event GameManagerEventHandler InventoryUIToggleEvent;
	public event GameManagerEventHandler RestartLevelEvent; 
	public event GameManagerEventHandler GoToMenuSceneEvent; 
	 


		public bool isGameOver;
		public bool isInventoryUIOn;
		public bool isMenuOn; 


	
		public void CallEventMenuToggle(){

			if (MenuToggleEvent != null) {
				MenuToggleEvent ();

			}

		}

		public void CallEventGameOver(){

			if (GameOverEvent != null) {

				isGameOver = true;
				GameOverEvent();

			}

		}


		public void CallInventoryUIToggle(){

			if (InventoryUIToggleEvent != null) {

				InventoryUIToggleEvent ();

			}

		}




}
}