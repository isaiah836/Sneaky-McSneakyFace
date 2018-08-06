using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hearing : MonoBehaviour {

    public bool inTrigger;
	public GameObject myAI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (inTrigger)// checks every update if the player is withing hearing range and if the player is making noise if so then the enemy ai can hear the player
        {
            if (GameManager.instance.playerSound > 0)
            {
                myAI.GetComponent<Enemy_AI_controller>().canHear = true;
            }
            else if (GameManager.instance.playerSound == 0)
            {
                myAI.GetComponent<Enemy_AI_controller>().canHear = false;
            }
        }
        if (!inTrigger) // if not then the enemy ai cant hear him
        {
            myAI.GetComponent<Enemy_AI_controller>().canHear = false;
        }
    }
    void OnTriggerEnter2D(Collider2D coll) //if the player has enter this collider then the player is withing listening range of enemy ai
    {
        if (coll.gameObject.tag == "player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D coll) // if the player exits this collider then the player is out of hearing range of the enemy ai
    {
        if (coll.gameObject.tag == "player")
        {
            inTrigger = false;
        }
    }
}
