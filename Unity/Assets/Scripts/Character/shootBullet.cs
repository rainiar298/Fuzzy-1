using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
		
	public GameObject Bullet;
	
	//enum Bullet_Type{Fire, Ice, Electric, Antimatter};
	void Shoot_Bullet(PowerUp.Element element, Vector3 position, Quaternion rotation)
	{
		GameObject newBullet = Instantiate(Bullet, position, rotation) as GameObject;
		Bullet script = (Bullet)newBullet.GetComponent("Bullet");
		script.Set_bullet_type(element);
		
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
			CharacterForm script = (CharacterForm)this.GetComponent("CharacterForm");
			if ((script.currentForm != PowerUp.Element.Normal) && (script.currentForm != PowerUp.Element.Magnetic))
				Shoot_Bullet(script.currentForm, spawnPoint.transform.position, transform.rotation);

		}
		
	}
}