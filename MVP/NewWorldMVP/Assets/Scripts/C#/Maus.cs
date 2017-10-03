using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maus : MonoBehaviour {
	//state = 0 undiscovered
	//state = 1 discovered
	//state = 2 explored
	//state = 3 colonized
	//state = 4 Settlement
	//state = 5 Win the game
	public int state = 0;
	public static int food = 500;
	public bool debug = true;
	public int explorationCost = 20;
	public int colonizationCost = 100;
	public int settlementCost = 200;

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

	public void ChangeColor (int index){
		GetComponent<SpriteRenderer>().color = stateColor[index];
//		if (debug) {
			Debug.Log ("Changing Color to " + stateColor [index]);
//		}
	}
		
	// Use this for initialization
	void Start () {
		ChangeColor (state);
	}

	void OnMouseDown(){

		switch (state) {
		case 0:
			Debug.Log ("Hex not accessible");
			break;

		case 1:
			if (food >= explorationCost) {
				food -= explorationCost;
				ChangeState ((state + 1) % numberOfStates);
			} else {
				Debug.Log ("Not enough Minerals");
			}
			break;

		case 2:
			if (food >= colonizationCost) {
				food -= colonizationCost;
				ChangeState ((state + 1) % numberOfStates);
			} else {
				Debug.Log ("Not enough Minerals");
			}
			break;

		case 3:
			if (food >= settlementCost) {
				food -= settlementCost;
				ChangeState ((state + 1) % numberOfStates);
			} else {
				Debug.Log ("Not enough Minerals");
			}
			break;

		default:
			Debug.Log ("Error: Unexpected state");
			break;
		}

		Debug.Log ("new Food: " + food);
	}


	


	void UpdateTown (){
		Debug.Log("Updating surrounding Hexes");

		if (eastHex != null && eastHex.GetComponent<Maus> ().state == 0) {
			eastHex.GetComponent<Maus> ().ChangeState (1);
		}
		if (northEastHex != null && northEastHex.GetComponent<Maus> ().state == 0) {
			northEastHex.GetComponent<Maus> ().ChangeState (1);
		}
		if (southEastHex != null && southEastHex.GetComponent<Maus> ().state == 0) {
			southEastHex.GetComponent<Maus> ().ChangeState (1);
		}
		if (southWestHex != null && southWestHex.GetComponent<Maus> ().state == 0) {
			southWestHex.GetComponent<Maus> ().ChangeState (1);
		}
		if (westHex != null && westHex.GetComponent<Maus> ().state == 0) {
			westHex.GetComponent<Maus> ().ChangeState (1);
		}
		if (northWestHex != null && northWestHex.GetComponent<Maus> ().state == 0) {
			northWestHex.GetComponent<Maus> ().ChangeState (1);
		}
	}

	public void ChangeState(int newState){
		if (newState >= 2) {
			UpdateTown();
		}
		state = newState;
		Debug.Log ("Changed state to " + newState);
		ChangeColor (newState);

	}
	// Update is called once per frame
	void Update () {
	}
}
