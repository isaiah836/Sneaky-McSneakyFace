using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_Pawn : Pawn {

	public Vector3 guardPosition;
    
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
	public override void HearPlayer()
	{
		Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
		LocalPosition.Normalize();
		float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, angle);
	}

	public override void ChasePlayer()
	{       
            Vector3 LocalPosition = GameManager.instance.player.transform.position - tf.position;
            LocalPosition.Normalize();
            float angle = Mathf.Atan2(LocalPosition.y, LocalPosition.x) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, GameManager.instance.enemyRotateSpeed * Time.deltaTime);
            tf.Translate(Vector3.right * Time.deltaTime * GameManager.instance.enemyMoveSpeed);
	}
    public override void ReturntoHomePosition()
    {
       // Vector3 defendLocation = guardPosition - tf.position;
        //defendLocation.Normalize();
        //float angle = Mathf.Atan2(guardPosition.y, guardPosition.x) * Mathf.Rad2Deg;
        //Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, GameManager.instance.enemyRotateSpeed * Time.deltaTime);
        //tf.Translate(Vector3.up * Time.deltaTime * GameManager.instance.enemyMoveSpeed);
    }
}
