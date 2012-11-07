var fireball : Rigidbody;
var speed = 50;

function Update() {
	if (Input.GetButton("Fire1")) {
		clone = Instantiate(fireball, transform.position, transform.rotation);
		clone.velocity = transform.TransformDirection(Vector3(0, 0, speed));
		clone.gameObject.tag = "projectile";
	}
	
	Destroy(clone.gameObject, 2.0);
}

