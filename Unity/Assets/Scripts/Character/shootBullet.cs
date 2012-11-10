using UnityEngine;
using System.Collections;

public class shootBullet : MonoBehaviour {
		
	public GameObject Bullet;
	public int bullet_speed=200;
	
	// Update is called once per frame
	void Update () {
		//CharacterController controller = GetComponent<CharacterController>();
		
		if (Input.GetButtonDown("Shoot"))
		{
			//Debug.Log ("Shoot");
			GameObject spawnPoint = GameObject.Find("spawnPoint");
			//Debug.Log (spawnPoint.transform.position);
			GameObject newBullet = Instantiate(Bullet, spawnPoint.transform.position, transform.rotation) as GameObject;
			newBullet.rigidbody.AddForce(transform.forward * bullet_speed);
		}
		
	}
}