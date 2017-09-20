using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maus : MonoBehaviour {
	
	Color terrainColor = Color.blue;

	// Use this for initialization
	void Start () {

	}
		
	void OnMouseDown()
	{
		if (terrainColor == Color.blue) {
			terrainColor = Color.red; 
		}
		else if(terrainColor == Color.red) {
			terrainColor = Color.blue;
		}

		GetComponent<SpriteRenderer>().color = terrainColor;

	}
	// Update is called once per frame
	void Update () {
	}
}
