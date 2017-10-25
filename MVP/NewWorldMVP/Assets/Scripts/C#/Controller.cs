using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	//Static Variables
	public static bool debug = true;
	public static int income;
	public static int food = 500;
	public static int actions;
	public static int maxActions = 1;
	public static int activeEvent;
	public static bool choiceMade =  false;
	public static int choiceID;
	//Base costs
	public static int[] cost = new int[]{0,20,100,200};

	//Base Income per state, will most likely change, maybe make it 2 Dimensional and have some sort of upgrades based on states? Not MVP relevant
	public static int[] basicIncome = new int[]{0,0,50,100,-100};

    public Material WoodFog;
    public Material Wood;
    public Material WoodUse;
    public Material FoodFog;
    public Material Food;
    public Material FoodUse;
    public Material IronFog;
    public Material Iron;
    public Material IronUse;
    public Material CoalFog;
    public Material Coal;
    public Material CoalUse;
    public Material Village;
    public Material Hidden;
    //total # of different states
    public static int states = 5;

	//The colors corespond to their state stateColor[0] is for state 0 etc.
	public static Color[] stateColor = new Color[] {Color.black, Color.blue, Color.white, Color.green, Color.yellow};
    public static Material[] stateMat = new Material[14];


	//Methods
	private void Start(){
		actionsReset();

        stateMat[0] = Hidden;
        stateMat[1] = WoodFog;
        stateMat[2] = Wood;
        stateMat[3] = WoodUse;
        stateMat[5] = FoodFog;
        stateMat[13] = Food;
        stateMat[6] = FoodUse;
        stateMat[7] = IronFog;
        stateMat[8] = Iron;
        stateMat[9] = IronUse;
        stateMat[10] = CoalFog;
        stateMat[11] = Coal;
        stateMat[12] = CoalUse;
        stateMat[4] = Village;


    }


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

	public static int getRandomEvent (){
		int maxEvent = RandomEvent.events.Length;
		int eventID = Random.Range (0, maxEvent);
		Debug.Log ("Event is " + eventID);
		return eventID;
	}
		
	public static void executeEvent (int eventID){
		
	}

}
