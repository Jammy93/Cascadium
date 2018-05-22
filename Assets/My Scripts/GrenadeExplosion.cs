using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this was found at https://www.youtube.com/watch?v=rCEVmh5YYpk&index=21&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5



namespace S3{
public class GrenadeExplosion : MonoBehaviour {




		private Collider[] hitColliders;
		public float blastRadius; 
		public float explosionPower; 
		public LayerMask explosionLayers; 
		private float destroyTime = 7; 


		void OnCollisionEnter(Collision col)
		{

			ExplosionWork (col.contacts [0].point); 
			Destroy (gameObject); 

		}

		void ExplosionWork(Vector3 explosionPoint) 
		{

			hitColliders = Physics.OverlapSphere (explosionPoint, blastRadius, explosionLayers); 

			foreach (Collider hitCol in hitColliders) {


				if (hitCol.GetComponent<Rigidbody> () != null) {

					hitCol.GetComponent<Rigidbody> ().isKinematic = false; 
					hitCol.GetComponent<Rigidbody> ().AddExplosionForce(explosionPower, explosionPoint, blastRadius, 1, ForceMode.Impulse);

				}


				if (hitCol.CompareTag ("Enemy")) {

					Destroy (hitCol.gameObject, destroyTime); 


				}



			}





		}






}
}