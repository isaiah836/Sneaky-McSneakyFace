using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hearing : MonoBehaviour {

    public bool inTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (inTrigger)
        {
            if (GameManager.instance.playerSound > 0)
            {
                gameObject.GetComponent<Enemy_AI_controller>().canHear = true;
            }
            else if (GameManager.instance.playerSound == 0)
            {
                gameObject.GetComponent<Enemy_AI_controller>().canHear = false;
            }
        }
        if (!inTrigger)
        {
            gameObject.GetComponent<Enemy_AI_controller>().canHear = false;
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            inTrigger = false;
        }
    }
}
