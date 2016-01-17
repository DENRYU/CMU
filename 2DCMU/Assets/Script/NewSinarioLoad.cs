using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text.RegularExpressions;

public class NewSinarioLoad : MonoBehaviour {
    public Text NT;//名前用テキスト
	public Text ST;//台詞用テキスト
    public string snam;
	//public string name;
	//public string seri;
	public int index;
	public string textdata;
	public string[] txt;
	public int sfinish = 0;//一度のセリフの終了の有無
	public char[] pattan;
	public int slf = 0;//台詞のテキストが終わっているか否かの確認
	public int sinfinish = 1;
	public int ctc = 0;//テキスト色を変えたフラグ
	// Use this for initialization
	void Start () {
		//ここでテキストの読み込み
        TextAsset ast = Resources.Load(snam) as TextAsset;
        
		//配列としてテキストデータを保存
		txt = ast.text.Split ('\n');
		/*
		foreach (string s in txt)
        {
            uiText.text += Cut(s) + "\n";
        }
		*/
    }
	
	// Update is called once per frame
	void Update () {
		if (sinfinish == 1) {
			if (Input.GetMouseButtonDown (0)) {
				ST.text = "";
				NT.text = "";
				sfinish = 0;
				while (sfinish == 0) {
					/*
					配列の割り振り処理
					1.pattan(char型配列にindex行目を格納)
					2.文の二文字目に特定の文字が入っているか確認
					3A.入っていなかった場合、そのまま進む
					3B.入っていた場合、それに対応した処理を行い、正しい場所に送る
					4.indexの数値を追加、次の行の確認。
					*/
					pattan = txt [index].ToCharArray ();
					Debug.Log ("二文字目は" + pattan [1]);
					Debug.Log ("最後の文字は" + pattan [pattan.Length - 2]);
					if (ctc != 0) {
						//テキストの色変更時の処理、一周するごとに白に戻す
						ST.color = Color.white;
						ctc = 0;
					}
					switch (pattan [1]) {
					case '/':
						Debug.Log ("/を取得しました");
					//ST.text = txt [index];
						slf = 1;
						ST.text += Cut (txt [index]) + "\n";
						while (slf == 1) {
							index++;
							pattan = txt [index].ToCharArray ();
							if (pattan [pattan.Length - 2] == '/') {
								slf = 0;
								sfinish = 1;
							}
							ST.text += Cut (txt [index]) + "\n";
						}
						break;
					case '@':
						Debug.Log ("@を取得しました");
					//NT.text = txt[index];
						//NT.color = Color.green;
						NT.text = Cut (txt [index]);
						break;
					case '+':
						Debug.Log ("+を取得しました");
						ST.color = Color.green;
						ST.text += Cut (txt [index]) + "\n";
						ctc = 1;
						break;
					case '-':
						Debug.Log ("-を取得しました");
						ST.color = Color.blue;
						ST.text += Cut (txt [index]) + "\n";
						ctc = 1;
						break;
					case '*':
						Debug.Log ("シナリオ終了");
						sinfinish = 0;
						break;
					default:
						Debug.Log ("なんでもないものを取得しました");
						break;
					}
					index++;
				}
				/*
					switch (pattan [pattan.Length - 2]) {
					case '/':
						Debug.Log ("セリフ終了");
						sfinish = 1;
						break;
					case '*':
						Debug.Log ("シナリオ終了");
						sinfinish = 0;
						break;
					default:
						Debug.Log ("まだ終わらない");
						break;
					}
					index++;
				//}
				*/
			}
		}
	}

    string Cut(string str)
    {
		//return str;

        string ret = "";
   //     string pattern = @"「([^」]+)」";
		string pattern = @"\w";
        foreach(Match m in Regex.Matches(str, pattern))
        {
            ret += m.Groups[0];
        }
        return ret;
        
    }
}
