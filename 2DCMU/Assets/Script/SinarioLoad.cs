using UnityEngine;
using System.Collections;
using System.IO;
using System;
using UnityEngine.UI;

public class SinarioLoad : MonoBehaviour {

    public string SName = "";

    public TextAsset ast;
    public string txdata;
    public int index;
    public char pattan;
    public string serihu;
    public string namae;
    public string ido;
    public string tui1;
    public string tui2;
    public int hen = 0;
    public int sf = 0;//セリフ出力フラグ
    //public string[] str;
    /*
    1:名前データ
    2:台詞データ
    */
  //  public float wait;
    public GUIText st;
    public GUIText nt;
	// Use this for initialization
	void Start () {
        TextLoad();
        txdata = ast.text;
    }
	
	// Update is called once per frame
	void Update () {
        if (pattan == '<')
        {            
            while (pattan != '>')
            {
                
                Debug.Log("ループ");
                index++;
                pattan = txdata[index];
                Debug.Log(pattan);
                switch (pattan)
                {
                    case 'n':
                        if (sf == 1)
                        {
                            while (pattan != '>')
                            {
                                index++;
                                pattan = txdata[index];
                            }
                            sf = 0;
                        }
                        else
                        {
                            Namaewaku();
                            // Debug.Log("名前");
                            Debug.Log("名前は" + namae.ToString());
                        }
                        break;
                    case 's':
                        Debug.Log("セリフ");
                        break;
                    default:
                        Debug.Log("ロード失敗");
                        
                        break;
                }
            }
        }
        else
        {
            index++;
        }

        pattan = txdata[index];
        st.text = ast.text;
        Debug.Log("一周");
	}

    void TextLoad()
    {
        ast = Resources.Load(SName) as TextAsset;
    } 

    void Namaewaku()
    {
        while (pattan == '<' || pattan == 'n' || pattan == '>')
        {
            index++;
            pattan = txdata[index];
        }
        while(pattan != '<')
        {
            
            Debug.Log("名前書き込み");
            /*
            問題点まとめ
            char型は日本語非対応→名前欄などの表示不可
            一応処理の始まりと終わりのみは固定化できているため、string型で処理を足せばいけるか？
            */
            /*
            ido = txdata[index].ToString();
            Debug.Log("移動は" + ido);
            */
            index++;
            
            pattan = txdata[index];
            ido = pattan.ToString();
            Debug.Log("配列内" + ido);
            if(hen == 0)
            {
                tui1 = ido;
            }
            if (hen % 2 == 0)
            {
                tui2 = tui1 + ido;
            }
            else
            {
                tui1 = tui2 + ido;
            }
            if (pattan == '<')
            {
                if(hen % 2 == 0)
                {
                    namae = tui1;
                }
                else
                {
                    namae = tui2;
                }
                
                break;
            }
            //namae = namae + pattan;
            hen = hen + 1;
        }
        sf = 1;
    }
}
