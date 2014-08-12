using UnityEngine;
using System.Collections;

public class Claim : MonoBehaviour {
	// Each location can have some or no claims on it
	// A claim is associated to one person

	Person claimant;
	// strength of the claim
	float strength;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void increaseClaim (float amount)
	// increases the person's claim on the 
	{
		strength+= amount;
	}

	float getStrength ()
	// returns the strength of this claim
	{
		return strength;
	}

}
