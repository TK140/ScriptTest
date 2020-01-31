using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// 配列（５個）を初期設定する
		int[] array = {11, 22, 33, 44, 55};

	    	// 配列の要素数の昇順に処理を繰り返す
		    for (int i = 0; i < array.Length; i++) {
		    	// 配列の要素を表示する
			    Debug.Log (array [i]);
			    }

		   // 配列の要素数の降順に処理を繰り返す
		   for (int j = array.Length - 1; j >= 0; j--) {
			   // 配列の要素を表示する
			   Debug.Log (array [j]);
		       }
	   }

	// Update is called once per frame
	void Update () {

	}
}
