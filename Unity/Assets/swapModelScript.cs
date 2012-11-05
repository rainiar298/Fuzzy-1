using UnityEngine;
using System.Collections;

public class swapModelScript : MonoBehaviour {
	
	public GameObject normalModel, fireModel, electricModel, iceModel, magneticModel, antimatterModel;
	private GameObject currentModel;
	
	// Use this for initialization
	void Start () {
		currentModel = Instantiate(normalModel, transform.position, transform.rotation) as GameObject;
    	currentModel.transform.parent = transform;
		currentModel.name = normalModel.name;
		
		ThirdPersonController tpc = (ThirdPersonController)transform.GetComponent ("ThirdPersonController");
		tpc.idleAnimation = normalModel.animation.GetClip ("Walk");
		tpc.walkAnimation = normalModel.animation.GetClip ("Walk");
		tpc.jumpPoseAnimation = normalModel.animation.GetClip ("Walk");
		tpc.runAnimation = normalModel.animation.GetClip ("Walk");
			
		
	}
	
	public void ChangeModel(string n)
	{
		if (n == "Fire")
		{
			GameObject thisModel = Instantiate(fireModel, transform.position, transform.rotation) as GameObject;
        	Destroy(currentModel);
        	thisModel.transform.parent = transform;
        	currentModel = thisModel;
			currentModel.name = fireModel.name;
		}
		else if (n == "Ice")
		{
			GameObject thisModel = Instantiate(iceModel, transform.position, transform.rotation) as GameObject;
        	Destroy(currentModel);
        	thisModel.transform.parent = transform;
        	currentModel = thisModel;
			currentModel.name = iceModel.name;
		}
		else if (n == "Electricity")
		{
			GameObject thisModel = Instantiate(electricModel, transform.position, transform.rotation) as GameObject;
        	Destroy(currentModel);
        	thisModel.transform.parent = transform;
        	currentModel = thisModel;
			currentModel.name = electricModel.name;
		}
		else if (n == "Magnetism")
		{
			GameObject thisModel = Instantiate(magneticModel, transform.position, transform.rotation) as GameObject;
        	Destroy(currentModel);
        	thisModel.transform.parent = transform;
        	currentModel = thisModel;
			currentModel.name = magneticModel.name;
		}
		else if (n == "Antimatter")
		{
			GameObject thisModel = Instantiate(antimatterModel, transform.position, transform.rotation) as GameObject;
        	Destroy(currentModel);
        	thisModel.transform.parent = transform;
        	currentModel = thisModel;
			currentModel.name = antimatterModel.name;
		}
	}
}
