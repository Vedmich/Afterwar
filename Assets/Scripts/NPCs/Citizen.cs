using UnityEngine;
using System.Collections;

public class Citizen : NPC 
{

	public int stressOnDeath;
	public int woundsInflicted;
	public bool isHostile;

	public void Init (string newName, int newStressOnDeath, int newWoundsInflicted) {
		name = newName;
		stressOnDeath = newStressOnDeath;
		woundsInflicted = newWoundsInflicted;
		isDead = false; 
		isHostile = false;

	}

	void Update () {
		if (this.isHostile) {
			npcAnimator.SetTrigger("isHostile");
			Debug.Log("isHostile here");

		} else if (this.isDead) {
			npcAnimator.SetTrigger("isDead");

		} else { 
			npcAnimator.SetTrigger("isAlive");
		}
	}

}
