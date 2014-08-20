using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour{
	// The actual map
	// Stores all the current blocks on this map instance
	Block[,] blocks;
	public int height,width;
	// Block Types:
	public Block beach;
	public Block desert;
	public Block field;
	public Block forest;
	public Block mountain;
	public Block ocean;
	public Block pond;
	public Block woods;

	// Use this for initialization
	void Start() {
		blocks = new Block[height,width];
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
				addBlock(i,j,thisBlock);
			}
		}
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
