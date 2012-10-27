#pragma strict

var distance = 10.0;
var xSpeed = 250.0;
var ySpeed = 120.0;

private var oldX = 0.0;
private var oldY = 0.0;

function LateUpdate () {
	var newX = Input.GetAxis("Mouse X");
    var newY = Input.GetAxis("Mouse Y");
    Debug.Log("Mouse:");
    Debug.Log(Input.GetAxis("MouseHorizontal"));
    Debug.Log(Input.GetAxis("MouseVertical"));
	//oldX = newX;
	//oldY = newY;	
}