using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	// Base class for all blocks (locations) on the map

	// (x,y) coordinates for the location of this block on the map.
	public int x, y;
	// list of resources at this block location.
	ArrayList resources = new ArrayList();
	// list of people with claims on this block and the strength of the claim
	ArrayList claims = new ArrayList();
	// list of people at this location currently
	ArrayList inhabitants = new ArrayList();
	// list of animals at this location currently
	ArrayList animals = new ArrayList();

	// Pop up variables
	public Rect windowRect;
	bool openPopUp = false;

	// Use this for initialization
	void Start () 
	{
		windowRect  = new Rect(transform.position.x*10, transform.position.y*10, 120, 50);
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnGUI() 
	{
		if(openPopUp)
		{
			windowRect = GUI.Window(0, windowRect, DoPopUp, "Action?");
		}
	}

	void OnMouseDown()
	{
		openPopUp=true;
	}

	void DoPopUp(int windowID) {
		if (GUI.Button(new Rect(10, 20, 100, 20), "Go Here"))
		{
			print("Go to "+this);
			print(transform.position.x+","+transform.position.y);
			openPopUp=false;
		}
	}

	public void addResource(Resource res)
	// Adds a resource to this location
	{
		resources.Add(res);
	}

	public ArrayList getResources()
	// Returns the resources at this location
	{
		return resources;
	}

	public void addClaim(Claim claim)
		// Adds a claim to this location
	{
		claims.Add(claim);
	}
	
	public ArrayList getClaims()
		// Returns the claims at this location
	{
		return claims;
	}

	public void addInhabitant(Person person)
		// Adds a person to this location
	{
		inhabitants.Add(person);
	}
	
	public ArrayList getInhabitants()
		// Returns the people at this location
	{
		return inhabitants;
	}

	public void addAnimal(Animal ani)
		// Adds an animal to this location
	{
		animals.Add(ani);
	}
	
	public ArrayList getAnimals()
		// Returns the animals at this location
	{
		return animals;
	}
}
