using UnityEngine;
using System.Collections;

public class warnings : MonoBehaviour
{
    public string input;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        int i;
        // give parsiong a shot
        try
        {
            i = int.Parse(input);
        }
        // nope, didn't work
        catch(UnityException e)
        {
           
Debug.LogWarning(e);
            i = 0;
        }
        Debug.Log("i =" + i);
	}
}
