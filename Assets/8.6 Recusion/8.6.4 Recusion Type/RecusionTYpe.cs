using UnityEngine;
using System.Collections;

public class RecusionTYpe : MonoBehaviour
{
	GameObject a;
	// Use this for initialization
	void Start ()
	{
		//-----------------------------------------------------
		a = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		int id = 0;
		a.name = "A_"+id.ToString();
		// Rotation the parent first
		
		for (int i = 0; i < 3; i++)
		{
			id++;
			
			GameObject b = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			b.name = "B_"+id.ToString();
			a.transform.localEulerAngles = new Vector3(0,(360/3) * i,0);
			b.transform.localPosition = new Vector3(6.0f,0,0);
			b.transform.parent = a.transform;
			
			for(int j = 0; j < 5 ; j++)
			{
				id++;
				//GameObject c = new GameObject("C_"+id.ToString());
				GameObject c = GameObject.CreatePrimitive(PrimitiveType.Capsule);
				c.name = "C_"+id.ToString();
				b.transform.localEulerAngles = new Vector3(0,(360/5) * j,0);
				c.transform.localPosition = new Vector3(2.0f,0,0);
				c.transform.parent = b.transform;
				
				for(int k = 0; k < 2 ; k++)
				{
					id++;
					//GameObject d = new GameObject("D_"+id.ToString());
					GameObject d = GameObject.CreatePrimitive(PrimitiveType.Cube);
					d.name = "D_"+id.ToString();
					c.transform.localEulerAngles = new Vector3(0,(360/2) * j,0);
					d.transform.localPosition = new Vector3(1.0f,0,0);
					d.transform.parent = c.transform;
				}
			}
		}
		//-----------------------------------------------
		ArrayList myList = GetList (a);
		foreach (GameObject go in myList)
		{
			Debug.Log(go.name);
		}
		//-----------------------------------------------------
	}
	
	ArrayList GetList(GameObject go) 
	{
		ArrayList list = new ArrayList ();
		BuildList (go, list);
		return list;
	}

	void BuildList(GameObject go,ArrayList l)
	{
		l.Add (go);
		for (int i = 0; i < go.transform.childCount;i++){
			GameObject g = go.transform.GetChild(i).gameObject;
			BuildList(g,l);
		}
	}

	void RotationHierarchy(GameObject go)
	{
		go.transform.Rotate(new Vector3(0f,0.5f,0f));
		for (int i = 0; i < go.transform.childCount; i++)
		{
			GameObject g = go.transform.GetChild(i).gameObject;
			RotationHierarchy(g);
		}
	}
	
	void Update()
	{
		RotationHierarchy (a);
	}



}
