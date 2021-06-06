// hit_a_piece.c
// arusuDev 2021/6/6
#include "gomoku.h"
#include <stdio.h>

// hit_a_piece関数
// 盤面にそのターンのコマを打ちます。
// input:
// 1: 盤面情報
// 2: 手番
void hit_a_piece(int board[BOARD_SIZE][BOARD_SIZE],int turn){
    int x,y;
    int flag;
    if(turn == 1){
        printf("黒番(o)です。");
    }else if(turn == -1){
        printf("白番(x)です。");
    }
    printf("\n\n");

    do{
        x = y = -1;
        flag = 0;
        print_board(board);
        printf("打ちたいマスを指定してください(x y) => ");
        scanf("%d %d",&x,&y);
        if(x <= 0 || y <= 0 || x>BOARD_SIZE || y > BOARD_SIZE){
            printf("盤面内を指定してください。\n");
            flag = 1;
        }
        if(board[y-1][x-1] != 0){
            printf("既に石が打たれている場所に打つことは出来ません。\n");
            flag = 2;
        }
    }while(flag != 0);
    board[y-1][x-1] = turn; 
}