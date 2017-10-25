using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Choice0 : MonoBehaviour, IPointerClickHandler {

	#region IPointerClickHandler implementation
	public void OnPointerClick (PointerEventData eventData)
	{

		Debug.Log("Click detected");
		Destroy(GameObject.Find("Cave Exploration"));

		Vector3 center = GameObject.Find ("Main Camera").transform.position;
		Instantiate(newPopup, center, Quaternion.identity);
	}
	#endregion
	public GameObject newPopup;
}
