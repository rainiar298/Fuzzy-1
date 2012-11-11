using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
	
	//private GameObject element;
	public enum Element{Fire, Ice, Electric, Antimatter, Normal, Magnetic}; //there is no normal PowerUp
	
	public GameObject fireModel, iceModel, electricModel, magneticModel, antimatterModel;
	public Element elementType = Element.Fire;
	
	private GameObject currentModel;
	
	void Start(){
		
		switch(elementType)
		{
			case Element.Fire:
				currentModel = Instantiate(fireModel, transform.position, transform.rotation) as GameObject;
				currentModel.name = fireModel.name;
				break;
			case Element.Ice:
				currentModel = Instantiate(iceModel, transform.position, transform.rotation) as GameObject;
				currentModel.name = iceModel.name;
				break;
			case Element.Electric:
				currentModel = Instantiate(electricModel, transform.position, transform.rotation) as GameObject;
				currentModel.name = electricModel.name;
				break;
			case Element.Magnetic:
				currentModel = Instantiate(magneticModel, transform.position, transform.rotation) as GameObject;
				currentModel.name = magneticModel.name;
				break;
			case Element.Antimatter:
				currentModel = Instantiate(antimatterModel, transform.position, transform.rotation) as GameObject;
				currentModel.name = antimatterModel.name;
				break;
		};
		
    	currentModel.transform.parent = transform;
	}
	
	void OnTriggerEnter(Collider col)
	{
		//Debug.Log("Collide");
    	if (col.tag == "Player")
    	{
        	CharacterForm script = (CharacterForm)col.GetComponent("CharacterForm");
			script.ChangeForm(elementType);
    	}
	}
}