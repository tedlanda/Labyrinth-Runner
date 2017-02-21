using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 

	bool locked = true;
	public AudioClip openDoor;
	public AudioClip lockedDoor;
	public AudioSource doorSound;


	void Update() {
		

		// If the door is unlocked and it is not fully raised
		if (transform.position.y < 17 && locked == false)
		{
		transform.Translate(0, 2.5f * Time.deltaTime, 0, Space.World);
			Debug.Log ("You may enter the temple");

		}
		// Animate the door raising up	

		}

    
	public void Unlock()
	{
		// You'll need to set "locked" to true here
		if (Key.gotKey) {
			locked = false;
		} 
	}
	public void OnDoorClicked()
	{
		Debug.Log ("This door is locked");
		if (Key.gotKey == true) 
		{
			doorSound.PlayOneShot (openDoor);

		} 
		else 
		{
			doorSound.PlayOneShot (lockedDoor);
		}
	}
}

