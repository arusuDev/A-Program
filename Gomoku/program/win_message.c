#include <stdio.h>
#include "gomoku.h"

// void win_message(int)
// 勝利メッセージの表示
// input : 勝利したサイド
void win_message(int turn){
    if(turn == BLACK){
        printf("黒番の勝ち！\n");
    }else if(turn == WHITE){
        printf("白番の勝ち！\n");
    }else{
        printf("引き分け！\n");
    }
}