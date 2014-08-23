using UnityEngine;
using System.Collections;

public class GameDriver : MonoBehaviour {
	// Drives the main game. Handles all global actions

	public bool popUpOpen = false; // So only one popup is around at once.
	public MainCharacter mainChar;
	protected MainCharacter player;

	// Use this for initialization
	void Start () {
		player = Instantiate(mainChar) as MainCharacter;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void sendCharTo(float x, float y)
	{
		player.goToLocation(new Vector2(x,y));
	}
}
