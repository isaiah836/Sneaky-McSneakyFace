using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_Pawn : Pawn {

	public Vector3 guardPosition; // the home position
	public float currentHealth; // the current health of the ai
	public Transform myBulletSpawn; //bullet spawn position
    
	// Use this for initialization
	public override void Start ()
	{
		base.Start();
		currentHealth = GameManager.instance.enemyMaxHealth; //sets the health of the ai
	}
	// Update is called once per frame
	void Update () {
		if (currentHealth < 1) //if health goes below zero hide turn off the ai
		{
			gameObject.SetActive(false);
		}
	}
	public override void Shoot() //
	{
		//Creates a bullet
		GameObject bullet = Instantiate(bulletPrefab, myBulletSpawn.position, myBulletSpawn.rotation);
	}
	public override void AIPatrol()
	{
		// the rotating patrol
		tf.Rotate(Vector3.forward * GameManager.instance.enemyRotateSpeed * Time.deltaTime);
	}
	public override void HearPlayer()
	{
		//this chunk of code makes the ai look towards the sound which is coming from the player.
		Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
		LocalPosition.Normalize();
		float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle);
	}

	public override void ChasePlayer()
	{       
		//this code chases the player and shoots at him
            Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
            LocalPosition.Normalize();
            float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, GameManager.instance.enemyRotateSpeed * Time.deltaTime);
            tf.Translate(Vector3.right * Time.deltaTime * GameManager.instance.enemyMoveSpeed);

		//this shoots the bullets
		Shoot();
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "bullet")
		{
			--currentHealth;
		}
		else
		{
			//do nothing
		}
	}
}
