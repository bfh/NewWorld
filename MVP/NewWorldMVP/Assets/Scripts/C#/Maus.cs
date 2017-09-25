using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maus : MonoBehaviour {
	//state = 0 undiscovered
	//state = 1 discovered
	//state = 2 explored
	//state = 3 conquered
	public int state = 0;

	//the number of states, used for changing states.
	int numberOfStates = 4;

	//The colors corespond to their states, color0 for state 0 color 1 for state 1 etc.
	Color color0 = Color.black;
	Color color1 = Color.blue;
	Color color2 = Color.green;
	Color color3 = Color.yellow;
	 
	// Use this for initialization

	void ChangeColor (Color newColor){
		GetComponent<SpriteRenderer>().color = newColor;
		Debug.Log ("Changing Color to " + newColor);
	}

	void Start () {
		ChangeColor (color0);
	}

	void OnMouseDown(){
		//
//		if (PlayerRessources.materials >= 100) {
//			PlayerRessources.materials -= 100;
			ChangeState ((state + 1) % numberOfStates);
//		} else {
			Debug.Log ("Not enough Minerals");
//		}
		}
		
	void ChangeState(int newState){
		state = newState;
		Debug.Log ("Changed state to " + newState);

		switch (state) {
		case 0:
			ChangeColor (color0);
			break;

		case 1:
			ChangeColor (color1);
			break;

		case 2:
			ChangeColor (color2);
			break;
		
		case 3:
			ChangeColor (color3);
			break;

		default:
			Debug.Log("Error: Unexpected state");
			break;
		}

	}
	// Update is called once per frame
	void Update () {
	}
}
