using UnityEngine;
using System.Collections;

public class ButtonS1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

	public void SceneLoad(){
		Debug.Log ("ボタンクリック1!");
		Application.LoadLevel("News");
	}

}
