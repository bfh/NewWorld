using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	//Static Variables
	public static bool debug = true;
	public static int income;
	public static int food = 500;
	public static int actions;
	public static int maxActions;

	//Base costs
	public static int[] cost = new int[]{0,20,100,200};

	//Base Income per state, will most likely change, maybe make it 2 Dimensional and have some sort of upgrades based on states? Not MVP relevant
	public static int[] basicIncome = new int[]{0,0,0,50,-100};

	//total # of different states
	public static int states = 5;

	//The colors corespond to their state stateColor[0] is for state 0 etc.
	public static Color[] stateColor = new Color[] {Color.black, Color.blue, Color.white, Color.green, Color.yellow};

	//Methods

	public static void actionsReset(){
		actions = maxActions;
	}

	public static bool PayUp(int cost){
		if (food >= cost) {
			food -= cost;
			return true;
		} else {
			Debug.Log ("Not enough Minerals");
			return false;
		}
	}

	public static void getRandomEvent (){
		int maxEvent = RandomEvent.events.Length;
		int eventID = Random.Range (0, maxEvent);
		Debug.Log (RandomEvent.events [eventID]);
	}
}
