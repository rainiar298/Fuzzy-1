#pragma strict

var speed = 5.0;
var rotateSpeed = 5.0;

function Update () {
	var controller : CharacterController = GetComponent(CharacterController);
	
	//Rotate around y-axis
	transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
	
	//Move forward/backward
	var forward = transform.TransformDirection(Vector3.forward);
	var currentSpeed = speed * Input.GetAxis("Vertical");
	controller.SimpleMove(forward * currentSpeed);
}

@script RequireComponent(CharacterController)