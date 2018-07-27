using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_controller : controller {

	float lastMovedTime;
    public bool canSee;
    public bool canHear;

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
		}
        else if (canHear == true)
        {
            HearPlayer();
            if (canSee == true)
            {
                ChasePlayer();
            }
            else if (canSee == false)
            {
                ReturntoHomePosition();
            }
            
        }
        else if (canSee == true)
        {
            ChasePlayer();
        }
        else
        {
            ()
        }
    }
}
