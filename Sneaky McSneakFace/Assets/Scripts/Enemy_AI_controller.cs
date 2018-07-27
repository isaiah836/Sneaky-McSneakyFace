using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_controller : controller {

	float lastMovedTime;

	// Use this for initialization
	void Start () {
		lastMovedTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if ((Time.time - lastMovedTime) > GameManager.instance.enemyTimeToMove)
		{
			lastMovedTime = Time.time;
			pawn.AIPatrol();
			//
		}
	}
}
