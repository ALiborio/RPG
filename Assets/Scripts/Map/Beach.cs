using UnityEngine;
using System.Collections;

public class Beach : Block {

	// Use this for initialization
	void Start () {
		// Initialize resources
		addResource(new Trees(0,20));
		addResource(new Stone(0,10));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
