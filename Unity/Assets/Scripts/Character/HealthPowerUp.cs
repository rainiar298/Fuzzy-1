using UnityEngine;
using System.Collections;

public class HealthPowerUp : MonoBehaviour {
	
	//private GameObject element	
	void Start(){
		
	}
	
	void OnTriggerEnter(Collider collidedObject)
	{
		//Debug.Log("Collided with Health-PowerUp");
    	if (collidedObject.tag == "Player")
    	{
        	CharacterHealth script = (CharacterHealth)collidedObject.GetComponent("CharacterHealth");
			Debug.Log ("Health:");
			if (!script.isFullHealth())
			{
				Debug.Log ("Can eat");
				script.AdjustCurrentHealth(10);
				Destroy(gameObject);
			}
    	}
	}
}