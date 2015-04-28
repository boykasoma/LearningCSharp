using UnityEngine;
using System.Collections;
using Tricks;
public class SimpleObjectExtension : object
{
	 GameObject gameObject;
	public SimpleObjectExtension(GameObject go)
	{
		this.gameObject = go;
		Debug.Log(" - "+go.name);

	}

	public void OnUpdate()
	{
		gameObject.Zero();
		Debug.Log("111111111");
        
	}
}
