using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SerihuP : MonoBehaviour {

	public Text st;//セリフ用テキスト
	int sp = 0;//セリフパターン
	int sp2 = 0;//直前に選ばれたセリフパターン
	public static int spsf = 0;//特殊なセリフフラグ
	// Use this for initialization
	void Start () {
		sp = 0;
		switch (spsf) {
		case 0:
			st.text = "こんにちは!";
			break;
		case 1:
			st.text = "あけましておめでとう!";
			break;
		case 2:
			st.text = "あなたは大人？まだ子供？";
			break;
		case 3:
			st.text = "今日はこの国が生まれた日だよ!";
			break;
		case 4:
			st.text = "たまには自然の中でのんびりしたいなぁ";
			break;
		case 5:
			st.text = "私たち、将来を託されてるんだよね";
			break;
		case 6:
			st.text = "今日は憲法記念日！…破っちゃだめだよ？";
			break;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			sp2 = sp;
			//st.text = "クリックされました";

			while(sp == sp2){
				sp = Random.Range(1,6);
			}
			switch(sp){
			case 1:
				st.text = "1のパターン";
				break;
			case 2:
				st.text = "2のパターン";
				break;
			case 3:
				st.text = "3のパターン";
				break;
			case 4:
				st.text = "4のパターン";
				break;
			case 5:
				st.text = "5のパターン";
				break;
			}
		}
		if (Input.touchCount > 0) {

			st.text = "タッチされました";
			Debug.Log("タッチ");
		}
	
	}
}
