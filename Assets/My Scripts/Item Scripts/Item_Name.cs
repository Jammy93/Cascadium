using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this was found at https://www.youtube.com/watch?v=COs3duOw3h8&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5&index=61

namespace S3{
public class Item_Name : MonoBehaviour {



		public string itemName; 




		void Start()
		{

			SetItemName (); 
		}


		void SetItemName()
		{

			transform.name = itemName; 
		}
}
}