using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace S3{
public class Player_Master : MonoBehaviour {

	//This code was found https://www.youtube.com/watch?v=baB1_Qjs3ys&list=PLwyZdDTyvucwjwqucleVQB7U12H2JPvg5&index=46


	public delegate void GeneralEventHandler();

	public event GeneralEventHandler EventInventoryChanged; 
	public event GeneralEventHandler EventHandsEmpty; 
	public event GeneralEventHandler EventAmmoChanged; 
	 



	public delegate void AmmoPickupEventHandler(string ammoName, int quantity); 
	public event AmmoPickupEventHandler EventPickedUpAmmo; 

	public delegate void PlayerHealthEventHandler(int healthChange);
	public event PlayerHealthEventHandler EventPlayerHealthDeduction;
	public event PlayerHealthEventHandler EventPlayerHealthIncrease;



	public void CallEventInventoryChanged()
	{
		if (EventInventoryChanged != null) {
			EventHandsEmpty ();
		}
	}



	public void CallEventHandsEmpty(){

		if (EventHandsEmpty != null) {


			EventHandsEmpty ();


		}




	}




	public void CallEventAmmoChanged()
	{
		if (EventAmmoChanged != null) {

			EventAmmoChanged ();
		}


	}

	public void CallEventPickedUpAmmo(string ammoName, int quantity)
	{
		if (EventPickedUpAmmo != null) {

		
			EventPickedUpAmmo (ammoName, quantity); 
		}
			


	}

	public void CallEventPlayerHealthDeduction(int dmg)
	{
		if (EventPlayerHealthDeduction != null) {

			EventPlayerHealthDeduction (dmg);

		}
	}

	public void CallEventPlayerHealthIncreased(int increase)
	{

		if (EventPlayerHealthIncrease != null) {


			EventPlayerHealthIncrease (increase);

		}


	}





}
}