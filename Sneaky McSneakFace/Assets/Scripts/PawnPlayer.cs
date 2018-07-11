using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnPlayer : Pawn
{

	public Transform tf;
	public Rigidbody2D rb;

	// Update is called once per frame
	void Update()
	{

	}
	public override void RotateLeft()
	{
		tf.Rotate(Vector3.forward * GameManager.instance.turnSpeed * Time.deltaTime);
	}
	public override void RotateRight()
	{
		tf.Rotate(Vector3.back * GameManager.instance.turnSpeed * Time.deltaTime);
	}
	public override void MoveForward()
	{
		tf.position += tf.rotation * (Vector3.up * GameManager.instance.moveSpeed * Time.deltaTime);
	}
	public override void MoveBack()
	{
		tf.position += tf.rotation * (Vector2.down * GameManager.instance.moveSpeed * Time.deltaTime);
	}
	public override void Shoot()
	{
		Debug.Log("PEW PEW PEW");
	}
}
