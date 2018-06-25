using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {
	//creates a variable for the transfrom component
	private Transform tf;

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		//Check every frame if the left or right or a and d keys are pressed
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			tf.Rotate(Vector3.forward * GameManager.instance.turnSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
			tf.Rotate(Vector3.back * GameManager.instance.turnSpeed * Time.deltaTime);
		}

		//CChecks every frame if the up or down or w or s keys are pressed
		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		{
			tf.position += tf.rotation * (Vector3.up * GameManager.instance.moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
		{
			tf.position += tf.rotation * (Vector2.down * GameManager.instance.moveSpeed * Time.deltaTime);
		}
	}
}
