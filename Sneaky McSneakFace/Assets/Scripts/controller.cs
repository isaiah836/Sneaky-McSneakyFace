using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class controller : MonoBehaviour {

	public Vector3 homeposition;
    public Pawn pawn;

	// Use this for initialization
	public virtual void Start () {
		pawn = GetComponent<Pawn>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
