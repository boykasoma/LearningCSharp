//#define TESTING
using UnityEngine;
using System.Collections;

public class Preprocessor : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		#if TESTING
			Debug.Log("Just testing");
		#endif
		Debug.Log("nomal behavious");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
