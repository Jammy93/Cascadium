using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this was found at https://www.youtube.com/watch?v=Fc-xqDRjKl8&index=59&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5

namespace S3{
public class Item_Pickup : MonoBehaviour {




		private Item_Master itemMaster; 
		private Transform myTransform; 


		void OnEnable()
		{

			SetInitialReferences (); 
			itemMaster.EventPickupAction += CarryOutPickupActions;
		}



		void OnDisable()
		{

			itemMaster.EventPickupAction -= CarryOutPickupActions;
		}







		void SetInitialReferences()
		{

			itemMaster = GetComponent<Item_Master> ();
		}


		void CarryOutPickupActions(Transform tParent)
		{

			transform.SetParent (tParent);
			itemMaster.CallEventObjectPickup ();
			transform.gameObject.SetActive (false); 

		}




}
}