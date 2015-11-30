using UnityEngine;
using System.Collections;

public class ButtonS1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButanC(){
		Debug.Log ("ボタンクリック1!");
	}

	public void SceneLoad(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
