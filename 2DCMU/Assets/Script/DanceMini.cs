using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DanceMini : MonoBehaviour {

	public Text LUB;
	public Text LDB;
	public Text RUB;
	public Text RDB;
	public static int LU = 0;
	public static int LD = 0;
	public static int RU = 0;
	public static int RD = 0;
	public static int jou = 0;
	public int sei = 100;
	public static int pc = 0;
	public int fpc = 5;
	public int a = 30;
	/*
	 * */
	// Use this for initialization
	void Start () {

		if (fpc < pc) {
			Application.LoadLevel("MiniDanceF");
		}

		while (LU == LD || LU == RU || LU == RD || LU == 0) {
			LU = Random.Range (1, 5);
		}
		while (LD == LU || LD == RU || LD == RD || LD == 0) {
			LD = Random.Range (1, 5);
		}
		while (RU == LU || RU == LD || RU == RD || RU == 0) {
			RU = Random.Range (1, 5);
		}
		while (RD == LU || RD == LD || RD == RU || RD == 0) {
			RD = Random.Range (1, 5);
		}

	}
	
	// Update is called once per frame
	void Update () {
		switch(jou){
		case 0:
			LUB.text = LU.ToString();
			LDB.text = LD.ToString();
			RUB.text = RU.ToString();
			RDB.text = RD.ToString();
			sei = sei - 1;
			if(sei < 0){
				jou = 1;
			}
			break;
		case 1:
			LUB.text = "";
			LDB.text = "";
			RUB.text = "";
			RDB.text = "";
			break;
		case 5:
			LUB.text = "OK";
			LDB.text = "OK";
			RUB.text = "OK";
			RDB.text = "OK";
			pc = pc + 1;

			while(a > 0){
				a = a - 1;
			}
		//	Debug.Log("さくじょぼうし");
		//	DontDestroyOnLoad(gameObject);
			LU = 0;
			LD = 0;
			RU = 0;
			RD = 0;
			jou = 0;
			Debug.Log(RD);
			Application.LoadLevel(Application.loadedLevel);
			//Application.LoadLevel("MiniDanceF");
			break;
		case 10:
			LUB.text = "NG";
			LDB.text = "NG";
			RUB.text = "NG";
			RDB.text = "NG";
			pc = pc + 1;

			while(a > 0){
				a = a - 1;
			}
			LU = 0;
			LD = 0;
			RU = 0;
			RD = 0;
			jou = 0;
			Debug.Log(RD);
			Application.LoadLevel(Application.loadedLevel);
			//Application.LoadLevel(Application.loadedLevel);
		
			break;
		default:
			break;
		}

	}
}
