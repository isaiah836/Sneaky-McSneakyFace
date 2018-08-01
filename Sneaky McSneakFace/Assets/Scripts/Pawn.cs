using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour {

	public Transform tf;

	// Use this for initialization
	public virtual void Start()
	{
		tf = GetComponent<Transform>();
	}
    //Movement for the player
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


    //this is the states for the AI 
	public virtual void AIPatrol()
	{

	}
	public virtual void HearPlayer()
	{

	}
	public virtual void ChasePlayer()
	{

	}
	

	public virtual void Shoot()
	{

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
