using UnityEngine;
using System.Collections;

public class CallBackWWW : MonoBehaviour {
	public delegate void delegateWWW(WWW www);
	// Use this for initialization
	void Start () 
	{
		StartCoroutine (getWWW("http://localhost/Unity/readText.txt",readText));
	
		//StartCoroutine (getWWW("http://localhost/Unity/Clementine_albedo_simp750.jpg",readTexture));
		
	}

	public void readText(WWW www)
	{
		Debug.Log(www.text);
	}
	public void readTexture(WWW www)
	{
		Texture2D texture = www.texture;
		gameObject.GetComponent<Renderer>().material.SetTexture("_MainTex",texture);
	}

	IEnumerator getWWW(string url,delegateWWW funcWWW)
	{
			WWW www = new WWW(url);
			yield return www;
			funcWWW(www);
	}
}

