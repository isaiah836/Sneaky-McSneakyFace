﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {

	private Transform tf;
	private float despawnTimer;
	private float timer;//timer

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>();
		despawnTimer = GameManager.instance.bulletLife; //the length of the bullets live
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		
		//limits how long the bullet stays on screen
		if (timer > despawnTimer)
		{
			Destroy(this.gameObject);
		}

		//moves the bullet
		tf.position += (transform.up * (Time.deltaTime * GameManager.instance.bulletSpeed));
	}
	void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log(collision);
		if (collision.gameObject.tag == "enemy") // if collides with enemy destroy this bullet
		{
			Destroy(this.gameObject);
		}
		if (collision.gameObject.tag == "wall") // if collides with wall destroy this bullet
		{
			Destroy(this.gameObject);
		}
	}
}
