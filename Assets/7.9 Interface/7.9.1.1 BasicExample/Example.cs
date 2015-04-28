using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Toaster T = new Toaster();
		T.ThingName = "Toash";
		print(T.ThingName);

		//Zombie Z = new Zombie();
		//Z.ThingName = "Zombie";
		//print(Z.ThingName);
		Zombie Z = (Zombie)gameObject.AddComponent("Zombie");
		Z.ThingName = "Zombie";
		Z.SayHello();
		print(Z.ThingName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
