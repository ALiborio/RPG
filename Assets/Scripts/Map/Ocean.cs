using UnityEngine;
using System.Collections;

public class Ocean : Block {

	// Use this for initialization
	void Start () {
		// Initialize resources
		addResource(new Oil(0,50));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
