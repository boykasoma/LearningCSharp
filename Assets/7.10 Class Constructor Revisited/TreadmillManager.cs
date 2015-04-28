using UnityEngine;
using System.Collections;

public class TreadmillManager : MonoBehaviour 
{
	private Obstacle[] obstacles;
	public int ObstacleCount = 10;
	delegate void UpdateObstacles(); // delegate function
	UpdateObstacles treadMillUpdates; // the delegate to assing functions
	 
	void Start()
	{
		obstacles = new Obstacle[ObstacleCount];

		// create a new array of the zize required
		for(int i = 0 ; i < ObstacleCount; i++)
		{
			obstacles[i] = new Obstacle(PrimitiveType.Sphere,
			Obstacle.MoveMentType.Static);
			//obstacles[i].InitObstacle(); // extra function call
			// fills in the array with new obstacles

			//assign each objects udpate to the delegate here
			treadMillUpdates += new UpdateObstacles(obstacles[i] .DrawObstacle);
		}
	}

	void Update()
	{
	//	foreach(Obstacle o in obstacles)
	//	{
	//		o.UpdatePosition(-0.01f);
	//	}
		Obstacle.UpdatePosition(-0.01f);
		treadMillUpdates();
	}

	class Obstacle
	{
		#pragma warning disable 0414
		MoveMentType movementType;
		#pragma warning restore 0414
		static float zPosition;
		private float myZposition;
		GameObject obstacle;
		public enum MoveMentType
		{
			Static,
			Wave,
			Left,
			Right
		}



		// constructor method
		public Obstacle(PrimitiveType privitive,MoveMentType movement)
		{
			obstacle = GameObject.CreatePrimitive(privitive);
			movementType = movement;

			myZposition = Random.Range(-10f,10f);
				obstacle.transform.position = new Vector3(
				Random.Range(-10f,10f),
				Random.Range(-10f,10f),
				Random.Range(-10f,10f));
		}
		//public void InitObstacle()
		//{
		//	obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
		//}

		// move the obstacle
		public static void UpdatePosition(float z)
		{
			//if(movementType == MoveMentType.Static)
			//{
			//	Vector3 pos = new Vector3(0,0,z);
			//	obstacle.transform.position += pos;
			//}

			zPosition += z;
		}
		public void DrawObstacle()
		{
			Vector3 pos = obstacle.transform.position;
			pos.z = (zPosition + myZposition) % 10;
			obstacle.transform.position = pos;
		}
	}
}
