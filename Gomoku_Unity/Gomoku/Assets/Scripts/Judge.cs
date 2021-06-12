using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 五目並べの勝利判定を行う関数。
/// </summary>
public partial class game : MonoBehaviour
{
    // 水平方向に勝敗が決定しているか判定する関数
    // 勝敗結果を返す。
    int horizontal_judge()
    {
        int x, y;
        int count;
        for (y = 0; y < BoardSize; y++)
        {
            for (x = 0; x < BoardSize - WinLength + 1; x++)
            {
                if (Board[y,x] == currentPlayer)
                {
                    for (count = 1; count < WinLength; count++)
                    {
                        if (Board[y,x + count] != currentPlayer)
                            break;
                    }
                    if (count == WinLength)
                    {
                        return currentPlayer;
                    }
                }
            }
        }
        return 0;
    }

    // 垂直方向に勝敗が決定しているか判定する関数
    // 勝敗結果を返す。
    int vertical_judge()
    {
        int x, y;
        int count;
        for (x = 0; x < BoardSize; x++)
        {
            for (y = 0; y < BoardSize - WinLength + 1; y++)
            {
                if (Board[y,x] == currentPlayer)
                {
                    for (count = 1; count < WinLength; count++)
                    {
                        if (Board[y + count,x] != currentPlayer)
                            break;
                    }
                    if (count == WinLength)
                    {
                        return currentPlayer;
                    }
                }
            }
        }
        return 0;
    }

    // 左上から右下へかけて勝敗が決定しているか判定する関数
    int lt_to_rd_judge()
    {
        int x, y;
        int count;
        for (x = 0; x < BoardSize - WinLength + 1; x++)
        {
            for (y = 0; y < BoardSize - WinLength + 1; y++)
            {
                if (Board[y,x] == currentPlayer)
                {
                    for (count = 1; count < WinLength; count++)
                    {
                        if (Board[y + count,x + count] != currentPlayer)
                            break;
                    }
                    if (count == WinLength)
                    {
                        return currentPlayer;
                    }
                }
            }
        }
        return 0;
    }

    // 右上から左下へかけて勝敗が決定しているか判定する関数
    int rt_to_ld_judge()
    {
        int x, y;
        int count;
        for (x = WinLength - 1; x < BoardSize; x++)
        {
            for (y = 0; y < BoardSize - WinLength + 1; y++)
            {
                if (Board[y,x] == currentPlayer)
                {
                    for (count = 1; count < WinLength; count++)
                    {
                        if (Board[y + count,x - count] != currentPlayer)
                            break;
                    }
                    if (count == WinLength)
                    {
                        return currentPlayer;
                    }
                }
            }
        }
        return 0;
    }

    // ボードにコマがすべて埋まっているかどうかを判定する
    // return:
    // -2 : すべて埋まっている場合
    // 0 : 空きマスがある場合
    // input :
    // board : 盤面情報
    int checkboard()
    {
        int x, y, flag = -2;
        for (y = 0; y < BoardSize; y++)
        {
            for (x = 0; x < BoardSize; x++)
            {
                if (Board[y,x] == 0)
                {
                    flag = 0;
                    break;
                }
            }
        }
        return flag;
    }
    // int judge(int Board[][],int currentPlayer)
    // 勝敗判定する関数
    // return:
    // 0 : 勝敗が決定していない状態
    // -2 : 盤面が全て埋まってしまった状態
    // BLACK : 黒が勝利
    // WHITE : 白が勝利
    // input:
    // board : 盤面情報
    // turn : 手番
    int judge()
    {
        int h = horizontal_judge();
        int v = vertical_judge();
        int lt_rd = lt_to_rd_judge();
        int rt_ld = rt_to_ld_judge();
        if (checkboard() == -2)
        {
            return -2;
        }
        if (h != 0 || v != 0 || lt_rd != 0 || rt_ld != 0)
        {
            return currentPlayer;
        }
        else
        {
            return 0;
        }
    }
}