using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_controller : controller {

    public Vector3 distanceFromPlayer;
    public bool canSee;
    public bool canHear;
    private Transform tf;
    public Transform pt;
	// Use this for initialization
	void Start () {
        tf = GetComponent<Transform>();
        GameManager.instance.enemyAI = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        
        distanceFromPlayer = GameManager.instance.player.transform.position - tf.position;
        distanceFromPlayer.Normalize();
        RaycastHit2D hit2D = Physics2D.Raycast(tf.position, distanceFromPlayer, GameManager.instance.enemySightDistance);
        Debug.DrawRay(tf.position, distanceFromPlayer * GameManager.instance.enemySightDistance, Color.green);
        Debug.Log(hit2D.collider.name);
        //this is the normal state of the AI it spins
        if (!canSee && !canHear)
        {
            pawn.AIPatrol();
        }
		if (hit2D.collider.name == "PlayerPawn")
		{
			canSee = true;
		}
        if (hit2D.collider.name.Contains("Building_Walls"))
        {
            canSee = false;
        }
        Debug.DrawRay(transform.position, (Vector3.forward * 10), Color.green);

        //Checks to see if ai can hear the player
        if (canHear == true)
        {
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
                pawn.ChasePlayer();
            }
            
        }
        if (canSee == true)
        {
            pawn.ChasePlayer();
        }
    }
}
