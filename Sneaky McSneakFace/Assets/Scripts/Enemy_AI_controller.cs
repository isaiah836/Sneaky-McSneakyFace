using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_controller : controller {

	float lastMovedTime;
    public bool canSee;
    public bool canHear;
	float lastSeen;

	// Use this for initialization
	void Start () {
		lastMovedTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		if ((Time.time - lastMovedTime) > GameManager.instance.enemyTimeToMove && canSee == false)
		{
			pawn.ReturntoHomePosition();
			lastMovedTime = Time.time;
			RaycastHit2D  hit2D = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector3.forward), GameManager.instance.enemySightDistance);
			pawn.AIPatrol();
			if (hit2D.collider != null && hit2D.collider.tag == "playersound")
			{
				canHear = true;
			}
			else if (hit2D.collider != null && hit2D.collider.tag == "player")
			{
				canSee = true;
			}
		}
        else if (canHear == true)
        {
			RaycastHit2D hit2D = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector3.forward), GameManager.instance.enemySightDistance);
            pawn.HearPlayer();
			if (hit2D.collider != null && hit2D.collider.tag == "player")
			{
				canSee = true;
			}
			else
			{
				canSee = false;
			}

			if (canSee == true)
            {
				lastSeen = Time.time;
                pawn.ChasePlayer();
            }
            else if (canSee == false)
            {
                pawn.ReturntoHomePosition();
            }
            
        }
        else if (canSee == true)
        {
            pawn.ChasePlayer();
			lastSeen = Time.time;
        }
    }
}
