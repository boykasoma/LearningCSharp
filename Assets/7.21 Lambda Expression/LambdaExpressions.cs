using UnityEngine;
using System.Collections;

public class LambdaExpressions : MonoBehaviour
{
	// create a delegate signature like befor
	delegate void MyDelegate();delegate int MyDelegate1(int i);


	void Start()
	{
		// assigne a new delegate and assign the expression at the same time
		MyDelegate mydelegateTest = () => Debug.Log("hello from lamp.");

		// call the new delegate
		mydelegateTest();

		MyDelegate1 mydelegateTest1 = (x) => x * x;
		int y = mydelegateTest1(5);
		Debug.Log(y);
	}
	 
}
