#define TESTING
using UnityEngine;
using System.Collections;

public class Directive : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        int playerHealth = 100;
#if TESTING
	//#warning DEBUG is on
        playerHealth = 10000;
#elif UNITY_EDITOR
        playerHealth = 10000;
                            
#endif
        if (playerHealth <0)
        {
            Debug.Log("Player has die");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
