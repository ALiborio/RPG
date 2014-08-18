using UnityEngine;
using System.Collections;

public class Forest : Block {

	// Use this for initialization
	void Start () {
		// Initialize resources
		addResource(new Trees(100,300));
		addResource(new Stone(25,100));
		addResource(new Iron(15,100));
		addResource(new Copper(15,100));
		addResource(new Gold(0,50));
		addResource(new Silver(0,60));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
