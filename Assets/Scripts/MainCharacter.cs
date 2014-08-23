using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {
	// This will represent the player in the game
	// It will also store the player's inventory and other stats

	public string playerName;
	public int 	health, stamina;
	protected Vector2 location;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Vector2 getLocation()
	{
		return location;
	}

	public void goToLocation(Vector2 loc)
	{
		print (loc.x+","+loc.y);
		location = loc;
		this.transform.position = new Vector3(loc.x,loc.y,this.transform.localPosition.z);

	}
}
