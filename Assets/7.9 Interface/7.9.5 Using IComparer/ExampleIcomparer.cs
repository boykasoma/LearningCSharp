using UnityEngine;
using System.Collections;

public class ExampleIcomparer : MonoBehaviour
{
	public GameObject[] sortedByDistance;

	void Update()
	{
		ArrayList ObjectList = new ArrayList();

		GameObject[] Objects = GameObject.FindObjectsOfType(typeof
		                                                    (GameObject)) as GameObject[];

		foreach(GameObject go in Objects)
		{
			ObjectList.Add (go);
		}

		DistanceComparer dComparer = new DistanceComparer();
		dComparer.Target = this.gameObject;
		ObjectList.Sort(dComparer);
		sortedByDistance = new GameObject[ObjectList.Count];
		ObjectList.CopyTo(sortedByDistance);
	}
}
