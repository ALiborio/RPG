using UnityEngine;
using System.Collections;

public class Mountain : Block {

	// Use this for initialization
	void Start () {
		// Initialize resources
		addResource(new Trees(0,100));
		addResource(new Stone(100,300));
		addResource(new Iron(25,150));
		addResource(new Copper(25,150));
		addResource(new Gold(0,75));
		addResource(new Silver(0,100));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
