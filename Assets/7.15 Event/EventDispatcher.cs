using UnityEngine;
using System.Collections;
using System;

public delegate void EventHandler();
public delegate void ProperEventHandler(object sender, EventArgs e);
public class EventDispatcher : MonoBehaviour 
{
	//public event EventHandler MyEvent;
	public event ProperEventHandler ProperEvent;
	public bool isClose;
	public bool SendEvent;
	public float distanceToPlayer;
	public GameObject target;
	void Update()
	{
		if(SendEvent)
		{

//			MyEvent();
			//ProperEvent(this,new MyEventArgs());
			if(ProperEvent != null)
			ProperEvent(this,new EventArgs<float>(3.14f));
			
			SendEvent = false;
		}

		target = GameObject.Find("Point light");
		Vector3 targetPlayer =	target.transform.position - transform.position;
		distanceToPlayer = targetPlayer.magnitude;
		if(distanceToPlayer <= 10 && !isClose)
		{
			if(ProperEvent != null)
			{
				ProperEvent(this,new EventArgs<float>(distanceToPlayer));

			}
			isClose = true;
		}

		if(distanceToPlayer > 10 && isClose)
		{
			isClose = false;
			if(ProperEvent != null)
			{
				ProperEvent(this,new EventArgs<float>(distanceToPlayer));
				
			}
		}
		if(ProperEvent == null)
		{
			Debug.Log("ProperEvent");
		}


	}
}
public class MyEventArgs : EventArgs
{
	public string MyNumber;
	public MyEventArgs()
	{
		MyNumber = "I just met you!!";
	}

	//------------------
} 
public class EventArgs<T> : EventArgs
{
	public T value;
	public EventArgs(T v)
	{
		value = v;
	}

}






 