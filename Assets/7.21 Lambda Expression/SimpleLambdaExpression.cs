using UnityEngine;
using System.Collections;

public class SimpleLambdaExpression : MonoBehaviour
{
	delegate void Mydelegate();

	void Start()
	{
		Mydelegate myDelegateTest = delegate()
		{
			Debug.Log ("Do action");
		};
		myDelegateTest();
	}
	 
}
