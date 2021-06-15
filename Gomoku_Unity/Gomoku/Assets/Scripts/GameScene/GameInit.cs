using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class game : MonoBehaviour
{
    /// <summary>
    /// ボード情報の初期化・ボードの作成を行う関数
    /// </summary>
    void Init(){
        // データを取る
        param = GameObject.Find("ScoreData");

        // ScoreDataがない場合、Scriptにアタッチされている値を直接使うようにする
        // MainSceneのデバッグ用
        if(param != null){
            dataCarry = param.GetComponent<DataCarry>();
            BoardSize = (int)dataCarry.bsize;
            WinLength = (int)dataCarry.cwin;
        }

        // Board変数を二次元配列で確保し、0でクリアする。
        Board = new int[BoardSize+1,BoardSize+1];
        MakeBoard();
        // 作成時は-1で、作成後は+1で。
        BoardSize++;
        CameraGet();

        showPieces = new GameObject[2];
        showPieces[0] = GameObject.Find("Black_S");
        showPieces[1] = GameObject.Find("White_S");

        showPieces[1].SetActive(false);
        if(showPieces == null){
            Debug.Log("読み込みエラー");
        }
    }
}