using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_Enemies : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameManager.instance.enemy.Add(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnDestroy()
    {
        GameManager.instance.enemy.Remove(this.gameObject);
    }
}
