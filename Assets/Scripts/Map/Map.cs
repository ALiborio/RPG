using UnityEngine;
using System.Collections;

public class Map {
	// The actual map
	// Stores all the current blocks on this map instance
	Block[,] blocks;

	// Use this for initialization
	public Map(int x, int y) {
		blocks = new Block[x,y];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addBlock(int x, int y, Block block)
	// (x,y) location and the block that will go there
	{
		blocks[x,y]=block;
	}

}
