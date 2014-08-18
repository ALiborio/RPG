using UnityEngine;
using System.Collections;

public class Field : Block {

	// Use this for initialization
	void Start () {
		// Initialize resources
		addResource(new Trees(0,10));
		addResource(new Stone(0,10));
		addResource(new Iron(0,20));
		addResource(new Copper(0,20));
		addResource(new Gold(0,20));
		addResource(new Silver(0,20));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
