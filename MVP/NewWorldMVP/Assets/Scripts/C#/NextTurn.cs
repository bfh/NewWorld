using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnClick(){
		Controller.food += Controller.income;
		Controller.actionsReset();
		Controller.getRandomEvent();
	}
	// Update is called once per frame
	void Update () {
	}
}
