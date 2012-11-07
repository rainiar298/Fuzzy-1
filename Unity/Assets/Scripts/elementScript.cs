using UnityEngine;
using System.Collections;

public class elementScript : MonoBehaviour {
	
	//private GameObject element;
	public string element;

	void OnTriggerEnter(Collider col)
	{
    	if (col.tag == "Player")
    	{
        	swapModelScript script = (swapModelScript)col.GetComponent("swapModelScript");
			script.ChangeModel(element);
    	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}