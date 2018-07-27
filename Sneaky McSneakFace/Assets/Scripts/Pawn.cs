﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour {

	public Transform tf;

	// Use this for initialization
	public virtual void Start()
	{
		tf = GetComponent<Transform>();
	}
	public virtual void RotateLeft()
	{

	}
	public virtual void RotateRight()
	{

	}
	public virtual void MoveForward()
	{

	}
	public virtual void RunForward()
	{

	}
	public virtual void MoveBack()
	{

	}

	public virtual void AIPatrol()
	{

	}
	public virtual void HearPlayer(bool canHear, bool canSee)
	{

	}
	public virtual void ChasePlayer(bool canSee)
	{

	}
	

	public virtual void Shoot()
	{

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
