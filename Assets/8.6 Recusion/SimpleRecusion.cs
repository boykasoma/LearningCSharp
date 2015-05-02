using UnityEngine;
using System.Collections;

public class SimpleRecusion : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
//		// for loop
//		for (int i = 0; i < 10; i ++)
//		{
//			Debug.Log ("for " + i.ToString());
//		}
//
//		// while loop
//		int j = 0;
//		while (j < 10)
//		{
//			Debug.Log ("while loop " + j.ToString());
//			j++;
//			
//		}
//
//		// do while
//		int k = 0;
//		do {
//			Debug.Log ("do while " + k.ToString ());
//			k++;
//		} while(k < 10);
//
//		// foreach
//		int[] ints = {0,1,2,3,4,5,6,7,8,9,10};
//		foreach (int l in ints)
//		{	
//			Debug.Log("Foreach " + l.ToString());
//
//		}
//
//		// while alternate
//		IEnumerator m = ints.GetEnumerator ();
//		while (m.MoveNext()) 
//		{
//			Debug.Log("IEnumerator " + m.Current.ToString());
//		}
//
//		// goto loop
//		int n = 0;
//	Start:
//			Debug.Log("goto " + n.ToString());
//			
//		n++;
//		if (n < 10)
//		{
//			goto Start;
//		}
		Recusion (0);
	}

	void Recusion(int i)
	{
		if (i > 10) {
			return;
		}
		Debug.Log("Recusion " + i.ToString());
		i++;
		Recusion(i);
	}


}
