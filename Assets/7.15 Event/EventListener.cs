using UnityEngine;
using System.Collections;
using System;
public class EventListener : MonoBehaviour
{
	public EventDispatcher dispatcher;
	void Start()
	{
//		dispatcher = GameObject.Find
//			("Main Camera").GetComponent<EventDispatcher>();
//		dispatcher.MyEvent += CallMeMaybe;
//		dispatcher.ProperEvent += CallMePlease;
	}
 
	void CallMeMaybe()
	{
		Debug.Log("Here my number");
	}
	// Update is Called once perframe
	void CallMePlease(object sender, EventArgs e)
	{
		Debug.Log(sender);
		MyEventArgs args = (MyEventArgs)e;
		Debug.Log(args.MyNumber);
	}
 
}
