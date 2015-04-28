using UnityEngine;
using System.Collections;

public class GenericsType : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
//		int first = 10;
//		int second = 20;
//		Debug.Log(first);
//		Debug.Log(second);
//		Swap(ref first,ref second);
//		Debug.Log(first);
//		Debug.Log(second);

//		ZombieGeneric first = new ZombieGeneric("AAAAAA");
//		ZombieGeneric second = new ZombieGeneric("BBBBBB");
//		Debug.Log(first);
//		Debug.Log(second);
//		Swap(ref first,ref second);
//		Debug.Log(first );
//		Debug.Log(second );

//		ZombieGeneric first = new ZombieGeneric("AAAAAA");
//		ZombieGeneric second = new ZombieGeneric("BBBBBB");
//		ZombieGeneric third = new ZombieGeneric("CCCC");
//		ThreeThing<ZombieGeneric> someThing = new ThreeThing<ZombieGeneric>(first,second,third);
//		Debug.Log(someThing);

		var twoNumber = new TwoThing<int,double>();
		twoNumber.AssignThing(4,50.0);

		var mixedThing = new TwoThing<ZombieGeneric,float>();
		mixedThing.AssignThing(new ZombieGeneric("dddd"),50f);
		
	}
	 

//	public void Swap<T>(ref T a, ref T b)
//	{
//		T temp = b;
//		b = a;
//		a = temp;
//	}
}

