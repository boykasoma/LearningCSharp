using UnityEngine;
using System.Collections;

public class DistanceComparer : IComparer
{
	public GameObject Target;
	public int Compare(object x, object y)
	{
		GameObject xobj = (GameObject)x;
		GameObject yobj = (GameObject)y;

		Vector3 tPos = Target.transform.position;
		Vector3 xPos = xobj.transform.position;
		Vector3 yPos = yobj.transform.position;

		float xDistance = (tPos - xPos).magnitude;
		float yDistance = (tPos - yPos).magnitude;

		if(xDistance > yDistance)
		{
			return 1;
		}
		else if(xDistance < yDistance)
		{
			return - 1;
		}
		else
		{
			return 0;
		}

	}
 
}
