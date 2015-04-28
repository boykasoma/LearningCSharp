using UnityEngine;
using System.Collections;

public class AccessorOrStruct : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        AccessorStruct MyAccessorStruct = new AccessorStruct();
        MyAccessorStruct.MyInt = 3;
        Debug.Log(" MyAccessorStruct :" + MyAccessorStruct.MyInt);

        MyAccessorStruct.SetInt(10);
        Debug.Log(" MyAccessorStruct :" + MyAccessorStruct.MyInt);

	} 
	
	 
}
struct AccessorStruct
{
    private int myInt;
    public int MyInt
    {
        get { return myInt;}
        set {myInt = value;}
    }

    public int GetInt()
    {
        return MyInt;
    }

    public void SetInt(int i)
    {
        MyInt = i;
    }
}
