using UnityEngine;
using System.Collections;

public class Resource {
	// All raw resources which can be harvested from blocks will be of this type
	// Once extracted they will become items (whether they have been refined into
	// products or not.

	public int max = 200;
	public int amount = 0;

	public Resource (int min, int max) 
		// Used for first initialization of this object
	{
		amount = Mathf.FloorToInt(max*Random.value);
	}
	
	public Resource (int amt)
		// Used to create an instance with the given amount
		// will be used to restore from a save
	{
		amount = amt;
	}

	public void Extract(int amt)
	// Extracts the given amount from the amount stored in this resource node
	{
		amount-=amt;
	}
}
