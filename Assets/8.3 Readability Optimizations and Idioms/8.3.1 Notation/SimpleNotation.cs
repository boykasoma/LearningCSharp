using UnityEngine;
using System.Collections;

public class SimpleNotation : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Debug.Log (GreateThan(10,20));
	}
	
	 int GreateThan(int a, int b)
	{
		return (a > b) ? a : b;
	}
}
