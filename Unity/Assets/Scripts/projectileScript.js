

function OnCollisionEnter(collision : Collision) {
	Debug.Log("haha " + collision.gameObject.tag);
	if (collision.gameObject.tag == "AI") {
		Destroy (collision.gameObject);
	}
}