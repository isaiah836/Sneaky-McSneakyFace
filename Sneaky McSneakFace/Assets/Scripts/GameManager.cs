using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	//Singleton
	public static GameManager instance;

	public GameObject player; // player gameobject
    public Transform playerP; // players position
	public float playerMoveSpeed; // player move speed
	public float runSpeedmultiplier; // run speed multiplier
	public float playerTurnSpeed; //player turn speed
	public float playerMaxHealth; //Max amount of health the player can have
	public float playerCurrentHealth; //the current health of the player
    public float playerSound; //sound made when running

    public List<GameObject> enemy; // list of enemies in scene
	public float enemyRotateSpeed; // how fast the enemy can rotate
	public float enemyMoveSpeed; // ai move speed
	public float enemySightDistance; //the distance of the enemies sight
	public float enemyMaxHealth = 3; //the maximum amount of health the enemy ai can have

	public GameObject level1;//hold the level gameobject
	public GameObject DefeatScreen;//holds the lose Screen gameobject
	public float bulletSpeed; //variable for bullet speed
	public float bulletLife; //length of bullet life

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

		//if the players health reaches zero it displays the lose screen
		if (playerCurrentHealth < 1)
		{
			level1.SetActive(false);
			DefeatScreen.SetActive(true);

		}
	}
	public void Quit()
	{
		//function used for quiting the game
		Debug.Log("Quit");
		Application.Quit();
	}
	public void RestarGame() //This function is used to restart the game and reset the position of the AI and the player
	{
		level1.SetActive(true);//turns the level on
		foreach (GameObject enemies in enemy) //for each enemy in the list it turns them back on and resets their position
		{
			enemies.SetActive(true);
			enemies.transform.position = enemies.GetComponent<Enemy_AI_Pawn>().guardPosition;
		}
		//resets the players position and resets the health back to the Max Health
		player.transform.position = player.GetComponent<PawnPlayer>().HomePosition;
		playerCurrentHealth = playerMaxHealth;
		player.GetComponent<PawnPlayer>().inTrigger = false;
	}
}
