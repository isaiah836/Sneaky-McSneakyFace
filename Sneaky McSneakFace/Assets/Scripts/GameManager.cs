using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	//Singleton
	public static GameManager instance;

	public GameObject player;
	public float playerMoveSpeed;
	public float playerTurnSpeed;
	public float playerMaxHealth;
	public int playerCurrentHealth;

	// Use this for initialization
	void Awake () {
		//Checks to see if there is another GameManger
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
