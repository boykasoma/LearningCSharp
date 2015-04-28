using UnityEngine;
using System.Collections;

public class BasicLambdas : MonoBehaviour
{
	// declare a delegate like before
	delegate void AnonExpression(string s) ;

	// Use this for initialization
	void Start()
	{
		// create and assinne the delegate here
		AnonExpression delAnonExpression = delegate(string s)
		{
			Debug.Log(s);
		};
		// observe the ; after the }

		//deleage content has been assigned
		// affter it's been assinged , we can use it.
		 
		delAnonExpression("Kasoma");
	}
}
