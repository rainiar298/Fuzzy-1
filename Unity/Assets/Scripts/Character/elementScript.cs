using UnityEngine;
using System.Collections;

public class elementScript : MonoBehaviour {
	
	//private GameObject element;
	public GameObject element;
	private GameObject currentModel;
	
	void Start(){
		currentModel = Instantiate(element, transform.position, transform.rotation) as GameObject;
    	currentModel.transform.parent = transform;
		currentModel.name = element.name;	
	}
	void OnTriggerEnter(Collider col)
	{
		//Debug.Log("Collide");
    	if (col.tag == "Player")
    	{
        	swapModel script = (swapModel)col.GetComponent("swapModel");
			script.ChangeModel(element.name);
    	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}