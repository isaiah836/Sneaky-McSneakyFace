using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawn : Pawn {

	// Use this for initialization
	public override void Attack()
	{
		base.Start();
	}
	public override void Attack () {
		Debug.Log("PEW PEW PEW");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
