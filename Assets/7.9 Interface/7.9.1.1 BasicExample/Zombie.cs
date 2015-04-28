using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour,IThing ,IDamage{

	private string ZombieName;
	private int ZombieHitPoints;
	public string ThingName
	{
		get 
		{
			return ZombieName;
		}
		set 
		{
			ZombieName = value;
		}

	}
	public void SayHello()
	{
		Debug.Log ("Zombie1");
	}

	public int HitPoints
	{
		get
		{
			return ZombieHitPoints;
		}
		set 
		{
			ZombieHitPoints = value;
		}
	}

	public void TakeDamage(int damage)
	{
		ZombieHitPoints -= damage;

	}
	public void HealDamage(int damage)
	{
		ZombieHitPoints += damage;
	}
}
