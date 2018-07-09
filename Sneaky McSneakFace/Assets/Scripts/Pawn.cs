using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour {

	public Transform tf;
	public Vector3 homePosition;

	public float moveSpeed;
	public float rotationSpeed;

	// Use this for initialization
	public virtual void Start()
	{
		tf = GetComponent<Transform>();
		homePosition = tf.position;
	}
	public virtual void Attack () {
		Debug.Log("This is a Parent Attack");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
