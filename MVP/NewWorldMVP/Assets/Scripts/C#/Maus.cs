using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Maus : MonoBehaviour , IPointerClickHandler {
	#region IPointerClickHandler implementation
	public void OnPointerClick (PointerEventData eventData)
	{
		//spawnEventCanvas();
		if (state != 0) {
			CheckResources ();
		} else {
			Debug.Log ("error");
		}
	}
	#endregion

	public int state = 0;
	public int[] cost = Controller.cost;
	public int[] baseIncome = Controller.basicIncome;
	int income;
	int incomeMod;
	public GameObject notificationCanvas;
	//Initialize neighbouring Hexes
	public GameObject northEastHex;
	public GameObject eastHex;
	public GameObject southEastHex;
	public GameObject southWestHex;
	public GameObject westHex;
	public GameObject northWestHex;

	//the number of states, used for changing states.
	int numberOfStates = Controller.states;

	// Use this for initialization
	void Start () {
		ChangeColor (state);
	}
		
	// Update is called once per frame
	void Update () {
		
	}


	void spawnEventCanvas(){
		Vector3 center = GameObject.Find ("Main Camera").transform.position;
		Instantiate(notificationCanvas, center, Quaternion.identity);

		GameObject[] optionButtons = GameObject.FindGameObjectsWithTag("Choice");
		Debug.Log (optionButtons);
	}


	void ChangeColor (int index){
		GetComponent<SpriteRenderer>().color = Controller.stateColor[index];
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
		UpdateIncome (baseIncome[state]+incomeMod);

	}

	//Call this method whenver you want to change the income, e.g. when changing states
	void UpdateIncome(int newIncome){
		Controller.income += (newIncome - income);
		income = newIncome;
	}


	//Checks if there are enough resources to change the state, if so it will do so
	void CheckResources(){
		bool change = Controller.PayUp(cost[state]);
		if (change) {
			ChangeState ((state + 1) % numberOfStates);
		}
		Debug.Log ("new Food: " + Controller.food);}
}
