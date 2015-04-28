using UnityEngine;
using System.Collections;

public class DestroyMe  
{
	public string name;
	// Constructor
	public DestroyMe(string name)
	{
		this.name = name;
		Debug.Log("SayHello" + name);
	}

	public void OnUpdate()
	{
		Debug.Log("UPDATE - : " + name);
		
	}

	~DestroyMe()
	{
		Debug.Log("Good bye" + name);
		
	}
}
