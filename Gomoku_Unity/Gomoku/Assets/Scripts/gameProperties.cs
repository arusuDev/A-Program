using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// gameクラスにおける各種パラメータを保持する
/// 基本的にPascal形式で命名する。
/// </summary>
public partial class game: MonoBehaviour
{
    // constでBlack,White,Noneを定義
    private const int Black = 1;
    private const int White = -1;
    private const int None = 0;

    
    // ボードのサイズを指定します。
    public int BoardSize = 9;
    // ボードを作成するためのオブジェクトを指定します。
    public GameObject[] BoardObjects = new GameObject[2];
    // 碁石を指定します。
    public GameObject[] GoPieces = new GameObject[2];
    // ボード上の判定用変数
    private int[,] Board;
    // 現在のターンがどっちかを示す関数
    int currentPlayer = Black;
    

}