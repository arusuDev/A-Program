using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class game : MonoBehaviour
{
    /// <summary>
    /// ボード情報の初期化・ボードの作成を行う関数
    /// </summary>
    void Init(){
        Board = new int[BoardSize,BoardSize];
        MakeBoard();
    }
}