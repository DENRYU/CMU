using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameCtrl : MonoBehaviour {
    

	struct SU{
		//羽唄ステータス
		public static int SU_KI  = 60;
		public static int SU_MEN = 60;
		public static int SU_NIN = 0;
		public static int SU_KOU = 30;
	};

	struct TS{
		//涼音ステータス
		public static int TS_KI  = 60;
		public static int TS_MEN = 60;
		public static int TS_NIN = 0;
		public static int TS_KOU = 30;
	};

	struct KY{
		//由梨奈ステータス
		public static int KY_KI  = 60;
		public static int KY_MEN = 60;
		public static int KY_NIN = 0;
		public static int KY_KOU = 30;
	};

	struct HM{
		//舞実ステータス
		public static int HM_KI  = 60;
		public static int HM_MEN = 60;
		public static int HM_NIN = 0;
		public static int HM_KOU = 30;
	};

	struct SA{
		//アリスステータス
		public static int SA_KI  = 60;
		public static int SA_MEN = 60;
		public static int SA_NIN = 0;
		public static int SA_KOU = 30;
	};

	struct KR{
		//瑠香ステータス
		public static int KR_KI  = 60;
		public static int KR_MEN = 60;
		public static int KR_NIN = 0;
		public static int KR_KOU = 30;
	};

	struct HA{
		//朱璃ステータス
		public static int HA_KI  = 60;
		public static int HA_MEN = 60;
		public static int HA_NIN = 0;
		public static int HA_KOU = 30;
	};

	struct IA{
		//愛花ステータス
		public static int IA_KI  = 60;
		public static int IA_MEN = 60;
		public static int IA_NIN = 0;
		public static int IA_KOU = 30;
	};

	struct GameAllDate{
		//ゲームのメインデータ
		public static string PLAYER_NAME;
		public static int SINARIO_SINKOU = 0;
	};

}
