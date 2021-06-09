using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class game : MonoBehaviour
{
    /// <summary>
    /// ボード情報の初期化・ボードの作成を行う関数
    /// </summary>
    void Init(){
        // Board変数を二次元配列で確保し、0でクリアする。
        Board = new int[BoardSize,BoardSize];
        MakeBoard();
        CameraGet();
    }
}