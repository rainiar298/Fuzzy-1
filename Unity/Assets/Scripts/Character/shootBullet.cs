using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
		
	public GameObject Bullet;
	
	//enum Bullet_Type{Fire, Ice, Electric, Antimatter};
	void Shoot(PowerUp.Element element, Vector3 position, Quaternion rotation)
	{
		//Debug.Log ("Shoot");
		
		GameObject newBullet = Instantiate(Bullet, position, rotation) as GameObject;
		Bullet script = (Bullet)newBullet.GetComponent("Bullet");
		script.Set_bullet_type(element);
		
		script.SendFlying();
	}
	
	// Update is called once per frame
	void Update () {
		//CharacterController controller = GetComponent<CharacterController>();
		
		CharacterForm script = (CharacterForm)this.GetComponent("CharacterForm");
		PowerUp.Element element = script.currentForm;
		//Debug.Log ("Before shooting");
		//Debug.Log (script.currentForm);
		
		if (Input.GetButtonDown("Shoot") && (tag == "Player"))
		{
			GameObject spawnPoint = GameObject.Find("spawnPoint");
			//Debug.Log (spawnPoint.transform.position);
			
			if ((script.currentForm != PowerUp.Element.Normal) && (script.currentForm != PowerUp.Element.Magnetic))
			{
				Debug.Log ("Trigger shooting");
				Debug.Log (script.currentForm);
				Shoot(script.currentForm, spawnPoint.transform.position, transform.rotation);
			}

		}
		
	}
}