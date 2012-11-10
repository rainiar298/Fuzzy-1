#pragma strict

function OnGUI () {
	// Make a background box
	GUI.Box (Rect (10,10,100,90), "Project Fuzzy");

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (20,40,80,20), "Start game")) {
		Application.LoadLevel (1);
	}

}