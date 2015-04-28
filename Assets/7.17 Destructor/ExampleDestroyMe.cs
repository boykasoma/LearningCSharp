using UnityEngine;
using System.Collections;
using System;
public class ExampleDestroyMe : MonoBehaviour 
{
	DestroyMe dm;
	int counter = 10;
	delegate void updateHandler();
	event updateHandler updateEvent;

	// Use this for initialization
	void Start () 
	{
		dm = new DestroyMe("rob");
		updateEvent += dm.OnUpdate;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(updateEvent != null)
		{
			updateEvent();
			counter--;
			if(counter < 0)
			{
				dm = null;
				updateEvent = null;
				GC.Collect();
			}
		}
	}
}
