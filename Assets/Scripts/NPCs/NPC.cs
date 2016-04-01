using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {

	public string name;
	public bool isDead = false;

	public Animator npcAnimator;

	protected void Start () {
		npcAnimator = GetComponent<Animator>();

	}

}
