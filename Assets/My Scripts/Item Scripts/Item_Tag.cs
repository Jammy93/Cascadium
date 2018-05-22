using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this was found at https://www.youtube.com/watch?v=aaUmaf40_ww&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5&index=60


namespace S3{
public class Item_Tag : MonoBehaviour {



		public string itemTag; 


		void OnEnable()
		{

			SetTag (); 
		}



		void SetTag(){



			if (itemTag == "") {

				itemTag = "Untagged"; 
			}

			transform.tag = itemTag; 
		}



}
}