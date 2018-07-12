using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour {

	public Image imageComponent; //public variable for image component.

	// Use this for initialization
	void Start () {
		imageComponent = GetComponent<Image>();
		//Make sure image is set to full
		imageComponent.type = Image.Type.Filled;
	}
	
	// Update is called once per frame
	void Update () {
		//find what percentage of max our current value is
		float percentOfMax = GameManager.instance.playerCurrentHealth / GameManager.instance.playerMaxHealth;
		// Set our image percentage to that same percent
		imageComponent.fillAmount = percentOfMax;
	}
}
