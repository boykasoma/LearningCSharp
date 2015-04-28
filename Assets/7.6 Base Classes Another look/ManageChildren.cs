using UnityEngine;
using System.Collections;

public class ManageChildren : MonoBehaviour {

	public Mesh ChildMesh;
	public Material ChildMaterial;
	BaseClass[] children;
	public int aMount;
	// Use this for initialization
	void Start ()
	{
		children = new BaseClass[2];

		children[0] = new ClassA();
		children[0].Initialize(ChildMesh,ChildMaterial);
		children[1] = new ClassB();
		children[1].Initialize(ChildMesh,ChildMaterial);
		 
        // ClassB cb = new ClassB();
        //cb.MyColor = new Color(1,1,1,1);
        //cb.Initialize(ChildMesh,ChildMaterial);
	}
	
	// Update is called once per frame
	void Update ()
	{
		for(int i = 0 ; i < children.Length; i ++)
		{
		 	children[i].MoveForward(i * 0.1f+ 0.1f,i * 3f + 1.5f);
		 	children[i].ChildUpdate();
			children[i].Speak();
		}
	}
}
