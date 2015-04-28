using UnityEngine;
using System.Collections;

public class IZombieEnumerator : IEnumerator
{
	private string[] minions;
	private int nextMinion = -1;
	
	public IZombieEnumerator(string[] strings)
	{
		minions = strings;
	}
	
	public object Current
	{
		get{return minions[nextMinion];}
	}
	
	public bool MoveNext()
	{
		nextMinion++;
		if(nextMinion >= minions.Length)
		{
			return false;
		}
		else
		{
			return true;
		}

	}
	public void Reset()
	{
		nextMinion = -1;
	}
}
