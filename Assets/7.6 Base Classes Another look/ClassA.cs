using UnityEngine;
using System.Collections;

public partial class ClassA : BaseClass
{
#region CHILDa_PROPERTIES
    protected GameObject me;
#endregion


	public override void SetShape(Shapes shape)
	{
		switch(shape)
		{
		case Shapes.Box:
			 this.me = GameObject.CreatePrimitive(PrimitiveType.Cube);
			break;
		case Shapes.Sphere:
			this.me = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			break;
		}
	}
	private float mScale;
	protected float MyScale
	{
		get{return mScale;}
		set{mScale = value;}
	}
	protected void SetScale(float scale)
	{
		MyScale = scale;
		me.transform.localScale = Vector3.one * MyScale;
	}
    public override void Initialize(Mesh mesh, Material material)
    {
        this.MyMesh = mesh;
        this.MyMaterial = MyMaterial;
		me = new GameObject(this.ToString());
		MyMeshFilter = me.AddComponent<MeshFilter>();
		MyMeshFilter.mesh = this.MyMesh;
		MyMeshRenderer = me.AddComponent<MeshRenderer>();
		MyMeshRenderer.material = this.MyMaterial;
    }

	public override void MoveForward(float speed,float turn)
	{
		Speed = speed;
		Turn = turn;
		ChildRotation = new Vector3(0f,Turn,0f);
	}

	public override void ChildUpdate()
	{
		ChildTransform = me.transform.forward * Speed;
		me.transform.localPosition += ChildTransform;
		me.transform.localEulerAngles = ChildRotation;

	}

	public override void Speak()
	{
		Debug.Log(me.name + "word");
	}
    //public override void Reset()
    //{

    //}
    


}
