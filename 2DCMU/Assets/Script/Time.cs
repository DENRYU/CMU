using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Time : MonoBehaviour {


	System.DateTime now = System.DateTime.Now;
	int hour;
	int minute;

	public Text tt;//時間表示用テキスト

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		now = System.DateTime.Now;

		hour = now.Hour;
		minute = now.Minute;

		tt.text = hour.ToString () + " : " + minute.ToString ();
		if (hour < 10) {
			tt.text = "0" + hour.ToString () + " : " + minute.ToString ();
		}
		if (minute < 10) {
			tt.text = hour.ToString () + " : 0" + minute.ToString ();
		}
		if (hour < 10 && minute < 10) {
			tt.text = "0" + hour.ToString () + " : 0" + minute.ToString ();
		}
	}
}
