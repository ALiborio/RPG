using UnityEngine;
using System.Collections;

public class Desert : Block {

	// Use this for initialization
	void Start () {
		// Initialize resources
		addResource(new Oil(0,200));
		addResource(new Stone(0,50));
		addResource(new Iron(0,50));
		addResource(new Copper(0,50));
		addResource(new Gold(0,25));
		addResource(new Silver(0,40));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
