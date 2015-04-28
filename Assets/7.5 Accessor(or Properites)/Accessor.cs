using UnityEngine;
using System.Collections;

public class Accessor : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        GetSet gs = new GetSet();
        gs.MyIntEvent += IntChagge;
        gs.MyInt = 10;
       Debug.Log(gs.DoubleInt);
	}

    void IntChagge(int i)
    {
        Debug.Log("MyInt :"+ i);
    }
	
	 
    
}
public class GetSet
{
    public delegate void MyIntHandler(int i);
    public event MyIntHandler MyIntEvent;
    private int myInt;
    public int MyInt
    {
        get { return myInt; }
        set
        {
            myInt = value;
            if (MyIntEvent != null)
            {
                MyIntEvent(myInt);
            }
        }

    }

    public int DoubleInt
    {
        get{

            return (myInt * 2);

        }
    }

   
}


