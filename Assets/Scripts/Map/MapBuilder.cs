using UnityEngine;
using System.Collections;

public class MapBuilder : MonoBehaviour {
	// Procedural generation of the map
	// According to some rules, we'll add different block types to the map
	// We'll also save the map's data to a permanent place

	public int width;
	public int height;

	public int blockTypes = 8;
	public Block beach;
	public Block desert;
	public Block field;
	public Block forest;
	public Block mountain;
	public Block ocean;
	public Block pond;
	public Block woods;

	public Map map;

	// Use this for initialization
	void Start () {
		width = map.width;
		height = map.height;
		Block thisBlock;
		for(int i=0; i<width; i++)
		{ for(int j=0; j<height; j++) 
			{
				if (i==0 || j==0 || i==(width-1) || j==(height-1))
				{
					thisBlock = Instantiate(ocean) as Block;
				}
				else
				{
					if (i==1 || j == 1 || i ==(width-2) || j==(height-2))
					{
						thisBlock = oceanOrBeach();
					}
					else
					{
					thisBlock = getNextBlock();
					}
				}
				map.addBlock(i,j,thisBlock);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	Block oceanOrBeach()
	// Returns an ocean or beach block
	{
		int type = Mathf.RoundToInt(Random.value);

		if (type == 1)
		{
			return Instantiate(beach) as Block;
		}
		else
		{
			return Instantiate(ocean) as Block;
		}
	}

	Block getNextBlock()
	// Generates the next block according to the rules
	// For now, just randomly picks a block type
	{
		Block block;
		int type = Mathf.FloorToInt(6*Random.value);
		switch(type)
		{
		case 0:
			block = pond;
			break;
		case 1:
			block = desert;
			break;
		case 2:
			block = field;
			break;
		case 3:
			block = forest;
			break;
		case 4:
			block = mountain;
			break;
		default:
			block = woods;
			break;
		}
		block = Instantiate(block) as Block;
		return block;

	}
}
