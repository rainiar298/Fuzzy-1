using UnityEngine;
using System.Collections;

public class AIStart : MonoBehaviour {

	public GameObject theModel;
	private GameObject currentModel;
	
	// Use this for initialization
	void Start () {
		currentModel = Instantiate(theModel, transform.position, transform.rotation) as GameObject;
    	currentModel.transform.parent = transform;
		currentModel.name = theModel.name;
		
		//ThirdPersonController tpc = (ThirdPersonController)transform.GetComponent ("ThirdPersonController");
		//tpc.idleAnimation = normalModel.animation.GetClip ("Walk");
		//tpc.walkAnimation = normalModel.animation.GetClip ("Walk");
		//tpc.jumpPoseAnimation = normalModel.animation.GetClip ("Walk");
		//tpc.runAnimation = normalModel.animation.GetClip ("Walk");
			
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
