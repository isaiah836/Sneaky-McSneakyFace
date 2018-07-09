using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour {

	public float maxHealth; // Public
	public float current; // Public variable for current heaalth
	public Image imageComponent; //public variable for image component.

	// Use this for initialization
	void Start () {
		//Make sure image is set to full
		imageComponent.type = Image.Type.Filled;
	}
	
	// Update is called once per frame
	void Update () {
		//find what percentage of max our current value is
		float percentOfMax = current / maxHealth;
		// Set our image percentage to that same percent
		imageComponent.fillAmount = percentOfMax;
	}
}
