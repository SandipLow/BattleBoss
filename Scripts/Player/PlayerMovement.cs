using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	public Rigidbody2D rb;


	// Update is called once per frame
	void Update () {

		horizontalMove = CrossPlatformInputManager.VirtualAxisReference("Horizontal").GetValue * runSpeed * 0.9f;
		// horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		// Debug.Log(horizontalMove);

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

	}

	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;

		// rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
		
	}

	public void Jump()
	{
		jump = true;
		animator.SetBool("IsJumping", true);
		
	}

}
