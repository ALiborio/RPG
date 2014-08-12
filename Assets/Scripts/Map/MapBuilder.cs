using UnityEngine;
using System.Collections;

public class MapBuilder : MonoBehaviour {
	// Procedural generation of the map
	// According to some rules, we'll add different block types to the map
	// We'll also save the map's data to a permanent place

	public int width  = 10;
	public int height = 10;

	public int blockTypes = 8;

	public Map map;

	// Use this for initialization
	void Start () {
		map = new Map(width,height);
		for(int i=0; i<10; i++)
		{ for(int j=0; j<10; j++) 
			{
				Block thisBlock = getNextBlock();
				Debug.Log(thisBlock);
				map.addBlock(i,j,thisBlock);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	Block getNextBlock()
	// Generates the next block according to the rules
	// For now, just randomly picks a block type
	{
		Block block = new Block();
		int type = Mathf.FloorToInt(8*Random.value);
		switch(type)
		{
		case 0:
			block = new Beach();
			break;
		case 1:
			block = new Desert();
			break;
		case 2:
			block = new Field();
			break;
		case 3:
			block = new Forest();
			break;
		case 4:
			block = new Mountain();
			break;
		case 5:
			block = new Ocean();
			break;
		case 6:
			block = new Pond();
			break;
		case 7:
			block = new Woods();
			break;
		default:
			block = new Beach();
			break;
		}
		return block;

	}
}
