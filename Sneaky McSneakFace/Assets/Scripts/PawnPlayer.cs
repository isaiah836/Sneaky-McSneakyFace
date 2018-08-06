using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnPlayer : Pawn
{
	public Transform myBulletSpawn; //the position of the bullet spawn for the shoot function to instantiate from
	public Vector3 HomePosition; // a home position for the player
	public bool inTrigger; // a bool that will allow me to see if the player is colliding with the enemy

	//initialize
	public override void Start()
	{
		base.Start();
	}
	// Update is called once per frame
	void Update()
	{
		if (inTrigger)
		{
			GameManager.instance.playerCurrentHealth -= (1 * Time.deltaTime);
		}
	}
	public override void RotateLeft() //rotates to the left
	{
		tf.Rotate(Vector3.forward * GameManager.instance.playerTurnSpeed * Time.deltaTime);
	}
	public override void RotateRight() //rotates the player to the right
	{
		tf.Rotate(Vector3.back * GameManager.instance.playerTurnSpeed * Time.deltaTime);
	}
	public override void MoveForward()// moves the player forward
	{
		tf.position += tf.rotation * (Vector3.right * GameManager.instance.playerMoveSpeed * Time.deltaTime);
	}
	public override void MoveBack() //Moves pawn backward
	{
		tf.position += tf.rotation * (Vector3.left * GameManager.instance.playerMoveSpeed * Time.deltaTime);
	}
	public override void RunForward() //Makes the pawn run forward
	{
		tf.position += tf.rotation * (Vector3.right * (GameManager.instance.playerMoveSpeed * GameManager.instance.runSpeedmultiplier) * Time.deltaTime);
	}

	public override void Shoot() // shoots bullets
	{
		GameObject bullet = Instantiate(bulletPrefab, myBulletSpawn.position, myBulletSpawn.rotation);
	}
	void OnCollisionEnter2D(Collision2D other) // this function turns in trigger on if the player is colliding with the enemy and subtracts health if the player is shot
	{
		if (other.gameObject.tag == "bullet")
		{
			--GameManager.instance.playerCurrentHealth;
		}
		if (other.gameObject.tag == "enemy")
		{
			inTrigger = true;
		}
	}
	void OnCollisionExit2D(Collision2D coll) // this function turn in trigger of if the player is no longer colliding with the enemy
	{
		if (coll.gameObject.tag == "enemy")
		{
			inTrigger = false;
		}
	}
}
