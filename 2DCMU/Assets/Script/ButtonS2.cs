﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ButtonS2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	public void SceneLoad(){
		Debug.Log ("ボタンクリック2!");
		Application.LoadLevel(Application.loadedLevel);
	}
	
}
