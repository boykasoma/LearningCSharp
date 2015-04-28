using UnityEngine;
using System.Collections;

public class ClassB : ClassA
{
#region CHILDb_PROPERTIES
	private Color mColor;
	public Color MyColor
	{
		get{return mColor;}
		set{mColor = value;}
	}
	
#endregion	

    //public override void Initialize(Mesh mesh, Material material)
    //{
    //    base.Initialize(mesh,material);
    //    this.MyColor = new Color(1f,0f,0f,1f);
    //    MyMeshRenderer.material.color = this.MyColor;
    //    SetScale(2.0f);
    //}	

}
