using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestCorotines : MonoBehaviour
{
    GameObject[] lostOfOjbect;
	// Use this for initialization
	void Start ()
    {
        //FillUpObject();
        StartCoroutine("FillOjbectIE");
	}
	
	 
    void FillUpObject()
    {
        lostOfOjbect = new GameObject[20000];
        for (int i = 0; i < 20000; i++)
        {
            GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
            g.name = i.ToString() + "_Cube";
            float rx = Random.Range(-1000, 1000);
            float ry = Random.Range(-1000, 1000);
            float rz = Random.Range(-1000, 1000);
            g.transform.position = new Vector3(rx, ry, rz);
            g.transform.localScale = new Vector3(10f, 10f, 10f);
            lostOfOjbect[i] = g;
        }
    }
    IEnumerator FillOjbectIE()
    {
        lostOfOjbect = new GameObject[20000];
        for (int i = 0; i < 20000; i++)
        {
            GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
            g.name = i.ToString() + "_Cube";
            float rx = Random.Range(-1000, 1000);
            float ry = Random.Range(-1000, 1000);
            float rz = Random.Range(-1000, 1000);
            g.transform.position = new Vector3(rx, ry, rz);
            g.transform.localScale = new Vector3(10f, 10f, 10f);
            lostOfOjbect[i] = g;
            yield return null;
        }
    }

    
}
