using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnPlayer : Pawn
{

	//initialize
	public override void Start()
	{
		base.Start();
	}
	// Update is called once per frame
	void Update()
	{

	}
	public override void RotateLeft()
	{
		tf.Rotate(Vector3.forward * GameManager.instance.playerTurnSpeed * Time.deltaTime);
	}
	public override void RotateRight()
	{
		tf.Rotate(Vector3.back * GameManager.instance.playerTurnSpeed * Time.deltaTime);
	}
	public override void MoveForward()
	{
		tf.position += tf.rotation * (Vector3.right * GameManager.instance.playerMoveSpeed * Time.deltaTime);
	}
	public override void MoveBack()
	{
		tf.position += tf.rotation * (Vector3.left * GameManager.instance.playerMoveSpeed * Time.deltaTime);
	}
	public override void RunForward()
	{
		tf.position += tf.rotation * (Vector3.right * (GameManager.instance.playerMoveSpeed * GameManager.instance.runSpeedmultiplier) * Time.deltaTime);
	}
	public override void Shoot()
	{
		Debug.Log("PEW PEW PEW");
	}
}
