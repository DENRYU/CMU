using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TH : MonoBehaviour {

    public static string[] MonSerihu = {"ひゃっほー","やっふー","いやっふー","ひゃっはー" };
    public static string[] TuesSerihu = { "a", "i", "u", "e" };
    public int so = 0;
    public GUIText karis;
    // Use this for initialization
    void Start () {
        SerihuC();
	}
	
	// Update is called once per frame
	void Update () {
      
	}
    void SerihuC()
    {
        so = Random.Range(0, 4);
        karis.text = MonSerihu[so];
        //return;
    }
}
