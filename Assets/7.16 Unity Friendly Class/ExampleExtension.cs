using UnityEngine;
using System.Collections;
using Tricks;
public class ExampleExtension : MonoBehaviour {

	public delegate void UpdateHandler();
	public event UpdateHandler UpdateEvent;



	// Use this for initialization
	void Start ()
	{
		SimpleObjectExtension so = new SimpleObjectExtension(this.gameObject);
		UpdateEvent += so.OnUpdate;
		 //gameObject.NewTrick(Vector3.one);
		 //gameObject.transform.Zero();
		 //gameObject.Zero();
	} 
	
	// Update is called once per frame
	void Update ()
	{
		if(UpdateEvent != null)
		{
			UpdateEvent();
		}
	}
}
namespace Tricks
{
    using UnityEngine;
    using System.Collections;
    public static class GameObjectExtension
    {
        public static void NewTrick(this GameObject go ,Vector3 pos)
        {
			go.transform.position = pos;
            Debug.Log(go.name);
        }

		public static void Zero (this Transform t)
		{
			t.position = Vector3.zero;
		}

		public static void Zero (this GameObject go)
		{
			go.transform.position = Vector3.zero;
		}
    }
}
