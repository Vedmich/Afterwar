using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float turnSmoothing = 15f;
	public float speedDampTime = 0.1f;

	private Animator playerAnimator;

	void Awake() 
	{
		playerAnimator = GetComponent<Animator>();
	}

	void FixedUpdate()
	{
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
	}

	void MovementManagement(float horizontal, float vertical)
	{
		if(horizontal !=0f || vertical !=0f)
		{
		}
	}

	void Rotating(float horizontal, float vertical)
	{
		Vector2 targetDirection = new Vector2(horizontal, vertical);
		Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector2.up);
		/*Quaternion newRotation = Quaternion.Lerp(rigidbody2D.rotation, targetRotation, turnSmoothing * Time.deltaTime);
		rigidbody.MoveRotation(newRotation);*/
	}
}
