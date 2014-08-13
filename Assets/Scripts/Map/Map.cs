using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour{
	// The actual map
	// Stores all the current blocks on this map instance
	Block[,] blocks;
	public int height,width;
	// Use this for initialization
	void Start() {
		blocks = new Block[height,width];
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void addBlock(int a, int b, Block block)
	// (x,y) location and the block that will go there
	{
		Debug.Log(a);
		Debug.Log(b);
		Debug.Log(block);
		blocks[a,b] = block;
		block.transform.localPosition = new Vector3(a,b,0);

	}

}
