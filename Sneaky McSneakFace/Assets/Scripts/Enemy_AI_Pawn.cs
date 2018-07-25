﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_Pawn : Pawn {

	// Use this for initialization
	public override void Start ()
	{
		base.Start();
	}
	 
	// Update is called once per frame
	void Update () {
		
	}
	public override void AIPatrol()
	{
		tf.Rotate(Vector3.forward * GameManager.instance.enemyRotateSpeed * Time.deltaTime);
	}
	public override void HearPlayer(bool canHear)
	{
		Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
		LocalPosition.Normalize();
		float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle);
	}
	public override void SeePlayer(bool CanSee)
	{

	}
	public override void ChasePlayer()
	{
		Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
		LocalPosition.Normalize();
		float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
		Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle - 90);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, GameManager.instance.enemyRotateSpeed * Time.deltaTime);
		tf.Translate(Vector3.up * Time.deltaTime * GameManager.instance.enemyMoveSpeed);
	}
}