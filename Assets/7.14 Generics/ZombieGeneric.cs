using UnityEngine;
using System.Collections;

public class ZombieGeneric 
{
	private string name ;
	// store the zombie name
	public ZombieGeneric(string aName)
	{
		name =aName;
	}
	// override the Tostring() comand by
	// returning the zobie name instread of its type

	public override string ToString ()
	{
		return name;
	}
}

public class ThreeThing<T>
{
	private T first;
	private T second;
	private T third;
	// constructor for three things
	public ThreeThing(T a,T b,T c)
	{
		first = a;
		second = b;
		third = c;
	}
	public override string ToString ()
	{
		return first + " - " + second + " - " + third;
	}

}

public class TwoThing<T ,U>
{
	#pragma warning disable 0414
	T firstThing;
	U secondThing;
	#pragma warning restore 0414

	public void AssignThing(T first,U second)
	{
		firstThing = first;
		secondThing = second;
	}
}
