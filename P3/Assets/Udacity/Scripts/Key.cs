using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoof;
	public Door doorOpen;
	public static bool gotKey;

	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
		
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Instantiate(KeyPoof, transform.position, Quaternion.Euler(-90, 0, 0));
		gotKey = true;
         
        // Call the Unlock() method on the Door

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
		Debug.Log ("You have collected the key and can now open the door!");
	
	}

}
