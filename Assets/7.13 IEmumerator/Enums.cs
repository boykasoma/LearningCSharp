using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Enums : MonoBehaviour {

	//int[] ints = {3,7,11,13,17,23,};

	string[] strings = {"A","B","C"};
	IEnumerator ie ;

	// Use this for initialization
	void Start ()
	{
//		 
//		 ie = ints.GetEnumerator();
//
//		while(ie.MoveNext())
//		{
//			Debug.Log(ie.Current);
//			 
//		}		
//		 
//		ie = strings.GetEnumerator();
//		while(ie.MoveNext())
//		{
//			Debug.Log(ie.Current);
//		}	
// 
		ZombieMaster o = new ZombieMaster("Boss",strings);
		IEnumerator ie = o.GetEnumerator();
		while(ie.MoveNext())
		{
			Debug.Log(ie.Current);
		}
		Debug.Log(ZombieMaster.ZombieMasterName);
	}
	
	 //zobie master
	class ZombieMaster : IEnumerable
	{
		public static string ZombieMasterName;
		private IZombieEnumerator Enmuerator;
		public ZombieMaster(string name,string[] strings)
		{
			ZombieMasterName =name;
			Enmuerator = new IZombieEnumerator(strings);

		}
		public IEnumerator GetEnumerator()
		{
			return Enmuerator;
		}
	}

//	class IZombieEnumerator :IEnumerator
//	{
//		private string[] minions;
//		private int nextMinion;
//
//		public IZombieEnumerator()
//		{
//			minions = new string[]{"222","333","444"};
//		}
//
//		public object Current
//		{
//			get{return new minions[nextMinion];}
//		}
//
//		public bool MoveNext()
//		{
//			nextMinion++;
//			if(nextMinion >= minions.Length)
//			{
//				return false;
//			}
//			else
//			{
//				return true;
//			}
//		}
//		public void Reset()
//		{
//			nextMinion = -1;
//		}
//	
//	}


























}
