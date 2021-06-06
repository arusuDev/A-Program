#include <stdio.h>
#include "gomoku.h"

int main(void){
    int board[BOARD_SIZE][BOARD_SIZE] = {0};
    int turn = 1;
    int win_side;

    printf("五目並べプログラム\n");
    print_board(board);
    do{
        win_side = judge(board,turn);
        turn_change(&turn);
    }while(win_side == 0);
    
    print_board(board);
    return 0;
}