using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this was found at https://www.youtube.com/watch?v=Bk48Y9qVNgw&index=98&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5


namespace S3{
public class Gun_Master: MonoBehaviour {

		public delegate void GeneralEventHandler(); 
		public event GeneralEventHandler EventPlayerInput; 
		public event GeneralEventHandler EventGunNotUsable; 
		public event GeneralEventHandler EventRequestReload; 
		public event GeneralEventHandler EventRequestGunReset; 
		public event GeneralEventHandler EventToggleBurstFire; 


		public delegate void GunHitEventHanlder(Vector3 hitPosition, Transform hitTransform); 
		public event GunHitEventHanlder EventShotDefault; 
		public event GunHitEventHanlder EventShotEnemy;


		public delegate void GunAmmoEventHandler(int currentAmmo, int carriedAmmo); 
		public event GunAmmoEventHandler EventAmmoChanged; 


		public delegate void GunCrosshairEventHandler(float speed); 
		public event GunCrosshairEventHandler EventSpeedCaptured; 


		public bool isGunLoaded; 
		public bool isReloading; 








		public void CallEventPlayerInput()
		{

			if (EventPlayerInput != null) {
				EventPlayerInput (); 
			}




		}


		public void CallEventGunNotUsable()
		{

			if (EventPlayerInput != null) {
				EventGunNotUsable (); 
			}




		}



		public void CallEventRequestReload()
		{

			if (EventPlayerInput != null) {
				EventRequestReload (); 
			}




		}



		public void CallEventRequestGunReset()
		{

			if (EventPlayerInput != null) {
				EventRequestGunReset(); 
			}




		}


		public void CallEventToggleBurstFire()
		{

			if (EventToggleBurstFire != null) {
				EventToggleBurstFire (); 
			}




		}


		public void CallEventShotDefault(Vector3 hPos, Transform hTransform)
		{

			if (EventShotDefault != null) {
				EventShotDefault (hPos, hTransform); 
			}




		}


		public void CallEventShotEnemy(Vector3 hPos, Transform hTransform)
		{

			if (EventShotEnemy != null) {
				EventShotEnemy (hPos, hTransform); 
			}




		}



		public void CallEventAmmoChanged(int curAmmo, int carAmmo)
		{

			if (EventAmmoChanged != null) {
				EventAmmoChanged (curAmmo, carAmmo); 
			}




		}


		public void CallEventSpeedCapturedt(float spd)
		{

			if (EventSpeedCaptured != null) {
				EventSpeedCaptured (spd); 
			}




		}



}
}