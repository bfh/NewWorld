using UnityEngine;
using System.Collections;

public class HexGrid : MonoBehaviour {
	public GameObject spawnThis;
	static GameObject startingHex;

	public int x = 5;
	public int y = 5;

	public float radius = 0.5f;
	public bool useAsInnerCircleRadius = false;


	private float offsetX, offsetY;

	void Start() {
		BuildMap();
		NewInTown();
		StartingPosition();


	

	}


	//Spawns the Hexmap with parameters given in the editor
	void BuildMap(){
		float unitLength = ( useAsInnerCircleRadius )? (radius / (Mathf.Sqrt(3)/2)) : radius;

		offsetX = unitLength * Mathf.Sqrt(3);
		offsetY = unitLength * 1.5f;
		Debug.Log("Start Spawing");

		for( int i = 0; i < x; i++ ) {
			for( int j = 0; j < y; j++ ) {
				Vector2 hexpos = HexOffset( i, j );
				Vector3 pos = new Vector3( hexpos.x, hexpos.y, 0 );
				GameObject newHex = Instantiate(spawnThis, pos, Quaternion.identity );
				newHex.name = "Hex [" + i + "," + j + "]";

			}
		}
		Debug.Log("All spwaned");
	}


	//asigns all hexes it's neighbouring hex	
	//reason this is done *after* all hexes are spawned is because you can't assign hexes that do not exist yet

	void NewInTown(){
		Debug.Log ("Starting assignment process");
		for( int i = 0; i < x; i++ ) {
			for( int j = 0; j < y; j++ ) {
				GameObject newHex = GameObject.Find ("Hex [" + i + "," + j + "]");
				if (j%2 ==1) {
					newHex.GetComponent<Maus> ().northEastHex = GameObject.Find ("Hex [" + (i + 1) + "," + (j + 1) + "]");
					newHex.GetComponent<Maus> ().eastHex = GameObject.Find ("Hex [" + (i + 1) + "," + j + "]");
					newHex.GetComponent<Maus> ().southEastHex = GameObject.Find ("Hex [" + (i + 1) + "," + (j - 1) + "]");
					newHex.GetComponent<Maus> ().southWestHex = GameObject.Find ("Hex [" + (i) + "," + (j - 1) + "]");
					newHex.GetComponent<Maus> ().westHex = GameObject.Find ("Hex [" + (i - 1) + "," + j + "]");
					newHex.GetComponent<Maus> ().northWestHex = GameObject.Find ("Hex [" + (i) + "," + (j + 1) + "]");
				} else  {
					newHex.GetComponent<Maus> ().northEastHex = GameObject.Find ("Hex [" + (i) + "," + (j + 1) + "]");
					newHex.GetComponent<Maus> ().eastHex = GameObject.Find ("Hex [" + (i + 1) + "," + j + "]");
					newHex.GetComponent<Maus> ().southEastHex = GameObject.Find ("Hex [" + (i) + "," + (j - 1) + "]");
					newHex.GetComponent<Maus> ().southWestHex = GameObject.Find ("Hex [" + (i-1) + "," + (j - 1) + "]");
					newHex.GetComponent<Maus> ().westHex = GameObject.Find ("Hex [" + (i - 1) + "," + j + "]");
					newHex.GetComponent<Maus> ().northWestHex = GameObject.Find ("Hex [" + (i-1) + "," + (j + 1) + "]");
				}
			}
		}
	}

	void StartingPosition(){
		startingHex = RandomHex (0, x, 0, y);
		startingHex.GetComponent<Maus> ().ChangeState (3);
	}

	GameObject RandomHex(int minRangeX, int maxRangeX, int minRangeY, int maxRangeY){

		Debug.Log("Determining random location");
		int startingX = Random.Range (minRangeX, maxRangeX);
		int startingY = Random.Range (minRangeY, maxRangeY);
		GameObject randHex = GameObject.Find ("Hex [" + startingX + "," + startingY + "]");

		Debug.Log ("Random hex: Hex [" + startingX + "," + startingY + "]");

		return randHex;
	}


	Vector2 HexOffset( int x, int y ) {
		Vector2 position = Vector2.zero;

		if( y % 2 == 0 ) {
			position.x = x * offsetX;
			position.y = y * offsetY;
		}
		else {
			position.x = ( x + 0.5f ) * offsetX;
			position.y = y * offsetY;
		}

		return position;
	}
}