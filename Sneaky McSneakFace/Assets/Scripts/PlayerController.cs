﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : controller {


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
		{
			pawn.Shoot();
		}
		//Check every frame if the left or right or a and d keys are pressed
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			pawn.RotateLeft();
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
			pawn.RotateRight();
		}

        //checks to see if the player is running
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameManager.instance.playerSound++;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            GameManager.instance.playerSound--;
        }
        //CChecks every frame if the up or down or w or s keys are pressed
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		{
            
			if (Input.GetKey(KeyCode.LeftShift))
			{
				pawn.RunForward();
			}
			else
			{
				pawn.MoveForward();
            }
        }
        
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
		{
			pawn.MoveBack();
		}
	}
}
