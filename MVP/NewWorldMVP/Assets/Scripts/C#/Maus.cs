using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maus : MonoBehaviour {
	//state = 0 undiscovered
	//state = 1 discovered
	//state = 2 explored
	//state = 3 conquered
	public int state = 0;
	public static int food = 500;
	public bool debug = false;
	public int cost = 0;

	//Initialize neighbouring Hexes
	public GameObject northEastHex;
	public GameObject eastHex;
	public GameObject southEastHex;
	public GameObject southWestHex;
	public GameObject westHex;
	public GameObject northWestHex;


	//the number of states, used for changing states.
	int numberOfStates = 4;

	//The colors corespond to their state stateColor[0] is for state 0 etc.
	static Color[] stateColor = new Color[] {Color.black, Color.blue, Color.white, Color.green, Color.yellow};

	//int food = 0;//player.GetComponent<PlayerRessources>().food;

	void ChangeColor (int index){
		GetComponent<SpriteRenderer>().color = stateColor[index];
		if (debug) {
			Debug.Log ("Changing Color to " + stateColor [index]);
		}
	}
		
	// Use this for initialization
	void Start () {
			ChangeColor (0);
	}

	void OnMouseDown(){
		if (food >= cost) {
			food -= cost;
			if (state == 1) {
				Debug.Log("state is 1");

				if (eastHex.GetComponent<Maus> ().state == 0) {
					eastHex.GetComponent<Maus> ().ChangeState (1);
				}
				if (northEastHex.GetComponent<Maus> ().state == 0) {
					northEastHex.GetComponent<Maus> ().ChangeState (1);
				}
				if (southEastHex.GetComponent<Maus> ().state == 0) {
					southEastHex.GetComponent<Maus> ().ChangeState (1);
				}
				if (southWestHex.GetComponent<Maus> ().state == 0) {
					southWestHex.GetComponent<Maus> ().ChangeState (1);
				}
				if (westHex.GetComponent<Maus> ().state == 0) {
					westHex.GetComponent<Maus> ().ChangeState (1);
				}
				if (northWestHex.GetComponent<Maus> ().state == 0) {
					northWestHex.GetComponent<Maus> ().ChangeState (1);
				}
			}
			ChangeState ((state + 1) % numberOfStates);
		//	if (debug) 
		//	{
				Debug.Log ("New Food = " + food);
		//	}
		} else {
			Debug.Log ("Not enough Minerals");		}
		}
		
	public void ChangeState(int newState){
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
