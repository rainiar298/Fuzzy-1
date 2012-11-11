using UnityEngine;
using System.Collections;

public class CharacterForm : MonoBehaviour {
	
	public GameObject normalModel, fireModel, electricModel, iceModel, magneticModel, antimatterModel;
	
	private GameObject currentModel;
	public PowerUp.Element currentForm;
	
	//public Element current_form;
	
	// Use this for initialization
	void Start () {
		currentModel = Instantiate(normalModel, transform.position, transform.rotation) as GameObject;
    	currentModel.transform.parent = transform;
		currentModel.name = normalModel.name;
		
		/*Movement tpc = (Movement)transform.GetComponent ("Movement");
		tpc.idleAnimation = normalModel.animation.GetClip ("Walk");
		tpc.walkAnimation = normalModel.animation.GetClip ("Walk");
		tpc.jumpPoseAnimation = normalModel.animation.GetClip ("Walk");
		tpc.runAnimation = normalModel.animation.GetClip ("Walk");*/
		
		currentForm = PowerUp.Element.Normal;
		
	}
	
	void change_model(GameObject new_model, Vector3 position, Quaternion rotation)
	{
		GameObject thisModel = Instantiate(new_model, position, rotation) as GameObject;
    	Destroy(currentModel);
    	thisModel.transform.parent = transform;
    	currentModel = thisModel;
		currentModel.name = new_model.name;
	}
	
	void change_form(PowerUp.Element newForm)
	{
		currentForm = newForm;
	}
	
	public void ChangeForm(PowerUp.Element element)
	{
		//disbable double jumping for all form, except Magnetic
		Movement script = (Movement)this.GetComponent("Movement");
		script.EnableMultipleJump(false);
		//script.Set_bullet_type(element);
		
		switch(element)
		{
			case PowerUp.Element.Normal:
				change_model(normalModel, transform.position, transform.rotation);
				change_form(PowerUp.Element.Fire);
			
				break;
			case PowerUp.Element.Antimatter:
				change_model(antimatterModel, transform.position, transform.rotation);
				change_form(PowerUp.Element.Antimatter);
			
				break;
			case PowerUp.Element.Fire:
				change_model(fireModel, transform.position, transform.rotation);
				change_form(PowerUp.Element.Fire);
			
				break;
			case PowerUp.Element.Ice:
				change_model(iceModel, transform.position, transform.rotation);
				change_form(PowerUp.Element.Ice);
			
				break;
			case PowerUp.Element.Electric:
				change_model(electricModel, transform.position, transform.rotation);
				change_form(PowerUp.Element.Electric);
			
				break;
			case PowerUp.Element.Magnetic:
				script.EnableMultipleJump(true);
				change_model(magneticModel, transform.position, transform.rotation);
				change_form(PowerUp.Element.Magnetic);
			
				break;
		};
	}
}
