using System.Collections;
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

	}
	public override void SeePlayer(bool CanSee)
	{

	}
	public override void ChasePlayer()
	{

	}
}
