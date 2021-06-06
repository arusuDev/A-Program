#include <stdio.h>
#include "gomoku.h"

// void print_horizon()
// 水平線を表示します。
void print_horizon(){
    int i;
    for (i = 0; i < BOARD_SIZE + 1; i++)
    {
        printf("---+");
    }
    printf("\n");
}

// void print_board(int[][])
// input : 盤面情報
// 盤面情報を表示する関数です。
void print_board(int board[BOARD_SIZE][BOARD_SIZE]){
    int i,j;
    printf("   |");
    for(i=0;i<BOARD_SIZE;i++){
        printf("%3d|",i+1);
    }
    printf("\n");
    print_horizon();

    for(i=0;i<BOARD_SIZE;i++){
        printf("%3d|",i+1);
        for(j=0;j<BOARD_SIZE;j++){
            if(board[i][j] == BLACK){
                printf(" o |");
            }else if(board[i][j] == WHITE){
                printf(" x |");
            }else{
                printf("   |");
            }
        }
        printf("\n");
        print_horizon();
    }
}