using UnityEngine;
using System.Collections;

public class SimpleCallBack : MonoBehaviour {

    delegate void delegateCaller();
    //delegateCaller caller = FunctionToCallAll;
	 
	 
    static void FunctionToCallAll()
    {
        Debug.Log("You called");
    }

    void Start()
    {
        StartCoroutine(StartsATask(PersonalCall));
        StartCoroutine(StartsATask(BusinessCall));
    }

    IEnumerator StartsATask(delegateCaller callThis)
    {
        Debug.Log("starting");
        yield return new WaitForSeconds(1);
        Debug.Log("Finishing");
        callThis();
        //callThis.PersonalCall();
        //caller();
    }

    void PersonalCall()
    {
        Debug.Log("PersonalCall");
    }
    void BusinessCall()
    {
        Debug.Log("BusinessCall");
    }
}
