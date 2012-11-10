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
	
	// Use this for initialization
	void Awake () {
		//Debug.Log ("Kill in 1.0f");
		Destroy(gameObject, life_time);
	}
	
	void Start(){
		//Debug.Log ("Transform pos");
		//Debug.Log (transform.position);
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
		//Debug.Log ("Model pos");
		//Debug.Log(currentModel.transform.position);
	}
	void OnTriggerEnter(Collider col)
	{
		Debug.Log("Collide");
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