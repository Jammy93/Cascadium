using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

// this was found at  https://www.youtube.com/watch?v=6yS7wA7mMm0&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5&index=84

namespace S3
{
public class Enemy_RagdollActivation : MonoBehaviour {




		private Enemy_Master enemyMaster; 
		private Collider myCollider; 
		private Rigidbody myRigidbody; 


		void OnEnable() {

			SetInitialReferences (); 
			enemyMaster.EventEnemyDie += ActivateRagdoll;

		}




		void OnDisable()
		{
			enemyMaster.EventEnemyDie -= ActivateRagdoll;


		}




		void Start()
		{




		}


		void Update()
		{



		}


		void SetInitialReferences()
		{

			enemyMaster = transform.root.GetComponent<Enemy_Master> (); 

			if (GetComponent<Collider> () != null) {

				myCollider = GetComponent<Collider> (); 

			}


			if (GetComponent<Rigidbody> () != null) {

				myRigidbody = GetComponent<Rigidbody> (); 

			}

		}


		void ActivateRagdoll()
		{


			if (myRigidbody != null) {

				myRigidbody.isKinematic = false; 
				myRigidbody.useGravity = true; 

			}

			if (myCollider != null) {
				myCollider.isTrigger = false;
				myCollider.enabled = true; 

			}

		}








}
}