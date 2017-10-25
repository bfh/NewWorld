using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChoiceButton : MonoBehaviour , IPointerClickHandler {
	#region IPointerClickHandler implementation
	public void OnPointerClick (PointerEventData eventData){
		Controller.choiceID = choiceID;
		choiceMade = true;
		Controller.executeEvent(Random.Range(0, 5));
	}

	#endregion

	public int choiceID;
	public bool choiceMade = false;
}
