using UnityEngine;
using System.Collections;

public class Levels : MonoBehaviour
{
    public LevelDetail[] levels;
	public TimeLeve[] timelevels;

    void Start()
    {
		if(levels.Length > 0)
		{
			timelevels = new TimeLeve[levels.Length];
			timelevels[1].TimeLevelName = "1111111";
			//Debug.Log("timelevels.Length"+ timelevels.Length);
		}
/*
		for (int i = 0; i < timelevels.Length; i++)
		{
			timelevels[i].TimeLevelName = "111";
			timelevels[i].timeEnemyDetail = new TimeEnemyDetail[2];
			if(timelevels[i].timeEnemyDetail.Length > 0)
			{
				for(int j = 0 ; i< timelevels[i].timeEnemyDetail.Length ; j++)
				{
					timelevels[i].timeEnemyDetail[j].enemyName = "1";
					timelevels[i].timeEnemyDetail[j].timeEnemyStartDetail = 1f;

				}	
			}		
		}

*/
			
	
		//	for (int i = 0; i < levels.Length; i++)
        //{
			//Debug.Log(levels[i].LevelName);
//			if(timelevels[i].TimeLevelName == null)

			 
		//	if(timelevels.Length > 0)
		//		timelevels[i].TimeLevelName = "111";
					

//			Debug.Log(levels[i].enemys.Length);

			//if(levels[i].enemys.Length > 0)
			//{
				//timelevels[i].timeEnemyDetail = new TimeEnemyDetail[levels[i].enemys.Length];
			//}
		// for(int j = 0 ; j < levels[i].enemys.Length; j++)
		 	//{
				//Debug.Log("Enemy name :" + levels[i].enemys[j].EnmeyName);
				//Debug.Log("Enemy name prefeb :" + levels[i].enemys[j].enemyDetila.EnemyName.name);
				//Debug.Log("amount name :" + levels[i].enemys[j].enemyDetila.amount);
				//Debug.Log("spawnWait:" + levels[i].enemys[j].enemyDetila.spawnWait);
				//Debug.Log("Timestart:" + levels[i].enemys[j].enemyDetila.Timestart);

//				timelevels[i].timeEnemyDetail[j].enemyName = levels[i].enemys[j].EnmeyName;
				
//				timelevels[i].timeEnemyDetail[j].timeEnemyStartDetail = levels[i].enemys[j].enemyDetila.Timestart;

				
		//	}
		//}
            
    }
}

[System.Serializable]
public class LevelDetail
{
    public string LevelName;
    public Enemys[] enemys;
}

[System.Serializable]
public class Enemys
{
    public string EnmeyName;
    public EnemyDetila enemyDetila;
}
[System.Serializable]
public class EnemyDetila
{
    public GameObject EnemyName;
    public int amount;
    public float spawnWait;
    public float Timestart;
}

[System.Serializable]
public class TimeLeve
{
	public string TimeLevelName;
	public TimeEnemyDetail[] timeEnemyDetail;
}

[System.Serializable]
public class TimeEnemyDetail
{
	public string enemyName;
	public float timeEnemyStartDetail;

}





