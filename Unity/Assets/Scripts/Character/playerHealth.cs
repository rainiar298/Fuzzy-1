using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	
	public int maxHealth = 100;
	public int currentHealth = 100;
	
	private float healthBarLength;

	// Use this for initialization
	void Start () {
		healthBarLength = Screen.width / 2;
	}
	
	// Update is called once per frame
	void Update () {
		AdjustCurrentHealth(0);
	}
	
	void OnGUI() {
		//only show health bar for players -> use this script for generic
		if (this.tag == "Player")
			GUI.Box(new Rect(0,0, healthBarLength, 20), currentHealth + "/" + maxHealth);	
	}
	
	void HandleDeath(int health)
	{
		Debug.Log("I died");
	}
	
	public void AdjustCurrentHealth(int adj){
		currentHealth += adj;
		//bound currentHealth value between 0 & maxHealth
		if (currentHealth < 0)
			currentHealth = 0;
		
		if (currentHealth > maxHealth)
			currentHealth = maxHealth;
		
		//handle death
		if (currentHealth <= 0)
			HandleDeath(currentHealth);
		
		//prevent division by 0
		if (maxHealth < 1)
			maxHealth = 1;
		
		healthBarLength = (Screen.width / 2) * (currentHealth / (float)maxHealth);
	}
	
}
