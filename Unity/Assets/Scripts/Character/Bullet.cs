using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	//private GameObject element;
	public GameObject Fire_bullet;
	public GameObject Ice_bullet;
	public GameObject Electric_bullet;
	public GameObject Antimatter_bullet;
	
	//public enum Bullet_Type{Fire, Ice, Electric, Antimatter};
	//public Bullet_Type bType;
	
	private GameObject currentModel;
	
	public float life_time=1.0f;
	public int bullet_speed=200;
	
	// Use this for initialization
	public void SendFlying() {
		//Debug.Log ("Kill in 1.0f");
		if (tag == "Player")
		{
			//Debug.Log("Send bullet flying");
		}
		
		rigidbody.AddForce(transform.forward * bullet_speed);
		Destroy(gameObject, life_time);
	}
	
	public void Set_bullet_type(PowerUp.Element element)
	{
		if (tag == "Player")
		{
			//Debug.Log("Call set bullet type");
		}
		
		switch (element)
		{
			case PowerUp.Element.Fire:
				currentModel = Instantiate(Fire_bullet, transform.position, transform.rotation) as GameObject;
				currentModel.name = Fire_bullet.name;
				break;
			case PowerUp.Element.Ice:
				currentModel = Instantiate(Ice_bullet, transform.position, transform.rotation) as GameObject;
				currentModel.name = Ice_bullet.name;
				break;
			case PowerUp.Element.Electric:
				currentModel = Instantiate(Electric_bullet, transform.position, transform.rotation) as GameObject;
				currentModel.name = Electric_bullet.name;
				break;
			case PowerUp.Element.Antimatter:
				currentModel = Instantiate(Antimatter_bullet, transform.position, transform.rotation) as GameObject;
				currentModel.name = Antimatter_bullet.name;
				break;
		};
		
		currentModel.transform.parent = transform;
	}
	
	void OnTriggerEnter(Collider collidedObject)
	{
		//Debug.Log("I am hit");
    	if ((collidedObject.tag == "Player") || (collidedObject.tag == "Enemy"))
    	{
        	CharacterHealth script = (CharacterHealth)collidedObject.GetComponent("CharacterHealth");
			script.AdjustCurrentHealth(-10);
			Destroy(gameObject);
    	}
	}
}