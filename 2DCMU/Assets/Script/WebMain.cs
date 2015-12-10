using UnityEngine;
using System.Collections;
/*最新
using UnityEngine.Experimental.Networking;
*/
using UnityEngine.UI;

public class WebMain : MonoBehaviour {
	/*
	最新
	UnityWebRequest request;
	*/
	public string url;
	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SetUrl(string str){
		url = str;
	}
	/*
	public void WebAccess(){
		print ("ACCESS" + url);
		StartCoroutine (WebAccessSub ());
	}
	IEnumerator WebAccessSub(){
		text.text = "Loading...";

		 * 最新
		request = UnityWebRequest.Get (url);
		request.Send ();
		while (!request.isDone) {
            text.text = "" + request.downloadProgress;
            yield return 0;
		}
		if (request.isError) {
			text.text = "ACCESS ERROR!:" + url;
		} else {
			text.text = "["+request.downloadHandler.text+"]";
		}
		*/
	}
//}
