using UnityEngine;
using System.Collections;

public class shootBullet : MonoBehaviour {
		
	public GameObject Bullet;
	
	enum Bullet_Type{Fire, Ice, Electric, Antimatter};
	void Shoot_Bullet(Bullet_Type bullet_type, Vector3 position, Quaternion rotation)
	{
		GameObject newBullet = Instantiate(Bullet, position, rotation) as GameObject;
		Bullet script = (Bullet)newBullet.GetComponent("Bullet");
		
		switch (bullet_type)
		{
			case Bullet_Type.Fire:
				script.Set_bullet_type("Fire");
				break;
			case Bullet_Type.Ice:
				script.Set_bullet_type("Ice");
				break;
			case Bullet_Type.Electric:
				script.Set_bullet_type("Electric");
				break;
			case Bullet_Type.Antimatter:
				script.Set_bullet_type("Antimatter");
				break;
		};
		
		script.Shoot();
	}
	
	// Update is called once per frame
	void Update () {
		//CharacterController controller = GetComponent<CharacterController>();
		
		if (Input.GetButtonDown("Shoot"))
		{
			//Debug.Log ("Shoot");
			GameObject spawnPoint = GameObject.Find("spawnPoint");
			//Debug.Log (spawnPoint.transform.position);
			Shoot_Bullet(Bullet_Type.Antimatter, spawnPoint.transform.position, transform.rotation);
		}
		
	}
}