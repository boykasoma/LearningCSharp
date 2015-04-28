using UnityEngine;
using System.Collections;

public class SimpleCallBackDynamic : MonoBehaviour 
{
    delegate void delegateCaller();
    

    void StartMessage()
    {
        Debug.Log("StartMessage");
    }
    void EndMessage()
    {
        Debug.Log("EndMessage");
    }
    void Start()
    {
        StartCoroutine(StartEndTask(StartMessage, 3, EndMessage));
    }

    IEnumerator StartEndTask(delegateCaller startFunc,float delay,delegateCaller endFunc)
    {
        startFunc();
        yield return new WaitForSeconds(delay);
        endFunc();
    }
	 
}
