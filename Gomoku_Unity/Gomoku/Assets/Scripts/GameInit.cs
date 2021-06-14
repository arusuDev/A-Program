using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class game : MonoBehaviour
{
    /// <summary>
    /// ボード情報の初期化・ボードの作成を行う関数
    /// </summary>
    void Init(){
        param = GameObject.Find("ScoreData");
        dataCarry = param.GetComponent<DataCarry>();
        BoardSize = (int)dataCarry.bsize;
        WinLength = (int)dataCarry.cwin;

        // Board変数を二次元配列で確保し、0でクリアする。
        Board = new int[BoardSize+1,BoardSize+1];
        MakeBoard();
        // 作成時は-1で、作成後は+1で。
        BoardSize++;
        CameraGet();
    }
}