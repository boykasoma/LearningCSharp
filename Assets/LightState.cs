using UnityEngine;
using System.Collections;
using System;
public class LightState : MonoBehaviour {
 
	public GameObject player;
	public float distanceToPlayer;
	public EventDispatcher dispatcher;
	public bool isClose;
	// Update is called once per frame
//	void Update ()
//	{
//		Vector3 targetPlayer =	player.transform.position - transform.position;
//		distanceToPlayer = targetPlayer.magnitude;
//
////		if(distanceToPlayer < 10.0f)
////		{
////			gameObject.GetComponent<Light>().intensity = 2.0f;
////		}else
////		{
////			gameObject.GetComponent<Light>().intensity = 0.1f;
////		}
//		 
//
//	}

	void Start()
	{
		dispatcher = GameObject.Find
			("Main Camera").GetComponent<EventDispatcher>();
		dispatcher.ProperEvent += ProximityEvent;
	}


	public void ProximityEvent(object sender, EventArgs e)
	{
		EventArgs<float> eval = (EventArgs<float>) e;
		Debug.Log (eval.value);
	
		if(eval.value > 10.0f)
		{
			gameObject.GetComponent<Light>().intensity = 0.1f;
		}else
		{
			gameObject.GetComponent<Light>().intensity = 2f;
		}

	}

	void Update()
	{
//		Vector3 targetPlayer =	player.transform.position - transform.position;
//		distanceToPlayer = targetPlayer.magnitude;
//		if(distanceToPlayer <= 10 && !isClose)
//		{
//			isClose = true;
//			
//		}
//		if(distanceToPlayer > 10 && isClose)
//		{
//			isClose = false;
//		}

	}
}
