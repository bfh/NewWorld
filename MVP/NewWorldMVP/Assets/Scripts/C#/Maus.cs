using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maus : MonoBehaviour {
	//state = 0 undiscovered
	//state = 1 discovered
	//state = 2 explored
	//state = 3 conquered
	public int state = 0;
	GameObject player;

	int food;
		
	bool debug = false;

	//the number of states, used for changing states.
	int numberOfStates = 4;

	//The colors corespond to their state stateColor[0] is for state 0 etc.
	static Color[] stateColor = new Color[] {Color.black, Color.blue, Color.blue, Color.green, Color.yellow};

	//int food = 0;//player.GetComponent<PlayerRessources>().food;

	void ChangeColor (int index){
		GetComponent<SpriteRenderer>().color = stateColor[index];
		Debug.Log ("Changing Color to " + stateColor[index]);
	}
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		if (player.GetComponent<PlayerRessources> ().food != null) {
		food = player.GetComponent<PlayerRessources>().food;
		}
	
		if (debug) 
		{
			ChangeColor (0);
		}
	}

	void OnMouseDown(){
		
		if (food >= 100) {
	//		food -= 100;
			ChangeState ((state + 1) % numberOfStates);
			if (debug) 
			{
	//			Debug.Log ("New Food = " + food);
			}
		} else {
			Debug.Log ("Not enough Minerals");		}
		}
		
	void ChangeState(int newState){
		state = newState;
		Debug.Log ("Changed state to " + newState);
		ChangeColor (newState);
		switch (state) {
		case 0:
			break;

		case 1:
			break;

		case 2:
			break;
		
		case 3:
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
