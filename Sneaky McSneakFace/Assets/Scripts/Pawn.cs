using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour {

	public Transform tf;
	public Vector3 homePosition;

	public float moveSpeed;
	public float rotationSpeed;

	// Use this for initialization
	public abstract void RotateLeft();
	public abstract void RotateRight();
	public abstract void MoveForward();
	public abstract void MoveBack();

	public abstract void Shoot();
	
	// Update is called once per frame
	void Update () {
		
	}
}
