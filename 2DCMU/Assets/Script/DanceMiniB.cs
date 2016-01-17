using UnityEngine;
using System.Collections;

public class DanceMiniB : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
	}
	public void OnClickLU(){
		if (DanceMini.LU == DanceMini.jou) {
			DanceMini.jou++;
		} else {
			DanceMini.jou = 10;
		}
	}
	public void OnClickLD(){
		if (DanceMini.LD == DanceMini.jou) {
			DanceMini.jou++;
		} else {
			DanceMini.jou = 10;
		}
	}
	public void OnClickRU(){
		if (DanceMini.RU == DanceMini.jou) {
			DanceMini.jou++;
		} else {
			DanceMini.jou = 10;
		}
	}
	public void OnClickRD(){
		if (DanceMini.RD == DanceMini.jou) {
			DanceMini.jou++;
		} else {
			DanceMini.jou = 10;
		}
	}
	public void Modo(){
		Application.LoadLevel ("MiniDance");
	}
}
