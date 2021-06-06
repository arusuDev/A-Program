#include <stdio.h>
#include "gomoku.h"

// void win_message(int)
// 勝利時のメッセージを表示する関数
// input : 勝利したサイド
void win_message(int turn){
    if(turn == BLACK){
        printf("黒番の勝ち！\n");
    }else{
        printf("白番の勝ち！\n");
    }
}