﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NextTurn : MonoBehaviour, IPointerClickHandler {
	#region IPointerClickHandler implementation
	public void OnPointerClick (PointerEventData eventData)
	{
		Controller.food += Controller.income;
		Controller.actionsReset();
		Controller.getRandomEvent();
		Debug.Log (Controller.food);
	}
	#endregion

}