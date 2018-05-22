using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson; 



//this was found at https://www.youtube.com/watch?v=x_6R7InDHp4&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5&index=34



namespace S3{
public class GameManager_TogglePlayer : MonoBehaviour {




		public FirstPersonController playerController; 
		private GameManager_Master gameManagerMaster; 



		void OnEnable()
		{
			SetInitialReferences ();
			gameManagerMaster.MenuToggleEvent += TogglePlayerController;
			gameManagerMaster.InventoryUIToggleEvent += TogglePlayerController;
		}



		void OnDisable()
		{
			gameManagerMaster.MenuToggleEvent -= TogglePlayerController;
			gameManagerMaster.InventoryUIToggleEvent -= TogglePlayerController;

		}


		void SetInitialReferences()
		{
			gameManagerMaster = GetComponent<GameManager_Master> ();

		}

		void TogglePlayerController()
		{
			if (playerController != null) {

				playerController.enabled = !playerController.enabled; 


			}



		}



}
}