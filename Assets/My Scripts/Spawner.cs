using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace S3{
public class Spawner : MonoBehaviour {

		public GameObject objectToSpawn;
		public int numberOfEnemies; 
		private float spawnRadius = 5;
		private Vector3 spawnPosition;


		void Start() 
		{

			SpawnObject (); 

		}







		void SpawnObject()
		{

			for(int i =0; i< numberOfEnemies; i++) 
			{

				spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius; 

				Instantiate (objectToSpawn, spawnPosition, Quaternion.identity); 
			}
		}



		}


}
