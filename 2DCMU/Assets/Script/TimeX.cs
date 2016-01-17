using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeX : MonoBehaviour {


	System.DateTime now = System.DateTime.Now;
	int hour;
	int minute;

	public GUIText tt;//時間表示用テキスト.

	// Use this for initialization
	void Start () {
        tt = GetComponent<GUIText>();
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
