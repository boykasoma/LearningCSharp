using UnityEngine;
using System.Collections;
using System.Reflection;
public class BasicReflection : MonoBehaviour {
	class subClassA
	{
		public static int firstInt;
		public string secondInt;
		public int thirdInt;

		public subClassA(int first,string second ,int third )
		{
			firstInt = first;
			secondInt = second;
			thirdInt = third;
			
		}
	}

	// Use this for initialization
	void Start () 
	{
		FieldInfo[] fields = typeof(subClassA).GetFields();
		foreach (FieldInfo field in fields)
		{
			Debug.Log (field.Attributes +" - "+ field.FieldType + " - "+ field.Name);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
