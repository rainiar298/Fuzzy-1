using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	//private GameObject element;
	public GameObject Fire_bullet;
	public GameObject Ice_bullet;
	public GameObject Electric_bullet;
	public GameObject Antimatter_bullet;
	
	public enum Bullet_Type{Fire, Ice, Electric, Antimatter};
	public Bullet_Type bType;
	
	private GameObject currentModel;
	
	public float life_time=1.0f;
	public int bullet_speed=200;
	
	// Use this for initialization
	public void Shoot() {
		//Debug.Log ("Kill in 1.0f");
		rigidbody.AddForce(transform.forward * bullet_speed);
		Destroy(gameObject, life_time);
	}
	
	public void Set_bullet_type(string new_type)
	{
		if (new_type == "Fire")
			bType = Bullet_Type.Fire;
		else if (new_type == "Ice")
			bType = Bullet_Type.Ice;
		else if (new_type == "Electric")
			bType = Bullet_Type.Electric;
		else if (new_type == "Antimatter")
			bType = Bullet_Type.Antimatter;
		
		switch (bType)
		{
			case Bullet_Type.Fire:
				currentModel = Instantiate(Fire_bullet, transform.position, transform.rotation) as GameObject;
				currentModel.name = Fire_bullet.name;
				break;
			case Bullet_Type.Ice:
				currentModel = Instantiate(Ice_bullet, transform.position, transform.rotation) as GameObject;
				currentModel.name = Ice_bullet.name;
				break;
			case Bullet_Type.Electric:
				currentModel = Instantiate(Electric_bullet, transform.position, transform.rotation) as GameObject;
				currentModel.name = Electric_bullet.name;
				break;
			case Bullet_Type.Antimatter:
				currentModel = Instantiate(Antimatter_bullet, transform.position, transform.rotation) as GameObject;
				currentModel.name = Antimatter_bullet.name;
				break;
		};
		
		currentModel.transform.parent = transform;
	}
	
	void Start(){
		//Debug.Log ("Transform pos");
		//Debug.Log (transform.position);
		
		
    	
		//Debug.Log ("Model pos");
		//Debug.Log(currentModel.transform.position);
	}
	void OnTriggerEnter(Collider col)
	{
		Debug.Log("I hit you");
    	if (col.tag == "Player")
    	{
        	//swapModel script = (swapModel)col.GetComponent("swapModel");
			//script.ChangeModel(element.name);
    	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}