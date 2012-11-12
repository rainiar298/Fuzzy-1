using UnityEngine;
using System.Collections;

public class CharacterForm : MonoBehaviour {
	
	public GameObject normalModel, fireModel, electricModel, iceModel, magneticModel, antimatterModel;
	
	private GameObject currentModel;
	public PowerUp.Element currentForm;
	
	//public Element current_form;
	
	// Use this for initialization
	void Start () {
		ChangeForm(currentForm);
	}
	
	void ChangeModel(GameObject new_model, Vector3 position, Quaternion rotation)
	{
		GameObject thisModel = Instantiate(new_model, position, rotation) as GameObject;
    	if (currentModel != null)
		{
			if (tag == "Enemy")
				Debug.Log ("Destroy current model for enemy");
			Destroy(currentModel);
		}
    	thisModel.transform.parent = transform;
    	currentModel = thisModel;
		currentModel.name = new_model.name;
	}
	
	void ChangeElement(PowerUp.Element newForm)
	{
		currentForm = newForm;
	}
	
	public void ChangeForm(PowerUp.Element element)
	{
		//disbable double jumping for all form, except Magnetic
		if (this.tag == "Player")
		{
			Movement script = (Movement)this.GetComponent("Movement");
			script.EnableMultipleJump(false);
			Debug.Log("Character form change");
			//Debug.Log(currentForm);
		}
		if (this.tag == "Enemy")
		{
			Debug.Log("Enemy change form");
		}
		
		switch(element)
		{
			case PowerUp.Element.Normal:
				ChangeModel(normalModel, transform.position, transform.rotation);
				ChangeElement(PowerUp.Element.Normal);
			
				break;
			case PowerUp.Element.Antimatter:
				ChangeModel(antimatterModel, transform.position, transform.rotation);
				ChangeElement(PowerUp.Element.Antimatter);
			
				break;
			case PowerUp.Element.Fire:
				ChangeModel(fireModel, transform.position, transform.rotation);
				ChangeElement(PowerUp.Element.Fire);
			
				break;
			case PowerUp.Element.Ice:
				ChangeModel(iceModel, transform.position, transform.rotation);
				ChangeElement(PowerUp.Element.Ice);
			
				break;
			case PowerUp.Element.Electric:
				ChangeModel(electricModel, transform.position, transform.rotation);
				ChangeElement(PowerUp.Element.Electric);
			
				break;
			case PowerUp.Element.Magnetic:
				
				if (this.tag == "Player")
				{
					Movement script = (Movement)this.GetComponent("Movement");
					script.EnableMultipleJump(true);
				}
			
				ChangeModel(magneticModel, transform.position, transform.rotation);
				ChangeElement(PowerUp.Element.Magnetic);
			
				break;
		};
	}
}
