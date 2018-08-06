using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

	public GameObject winScreen;
	public GameObject level1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D coll) // this function will activate the win screen when the player enters the collider
	{
		if (coll.gameObject.tag == "player")
		{
			winScreen.SetActive(true);
			level1.SetActive(false);
			
		}
	}
}
