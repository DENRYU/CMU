// Get the latest webcam shot from outside "Friday's" in Times Square
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Web : MonoBehaviour {
	public Text st;
	public string url = "http://news.yahoo.co.jp/list/?d=20151201";
	IEnumerator Start() {
		WWW www = new WWW(url);
		yield return www;
	//	Renderer renderer = GetComponent<Renderer>();
//		renderer.material.mainTexture = www.texture;
//		st = www.ToString ();
	}
}