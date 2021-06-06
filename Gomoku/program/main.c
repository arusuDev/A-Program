#include <stdio.h>
#include "gomoku.h"

int main(void){
    int board[BOARD_SIZE][BOARD_SIZE] = {0};
    int turn = BLACK;
    int win_side;

    printf("ŒÜ–Ú•À‚×ƒvƒƒOƒ‰ƒ€\n");
    print_board(board);
    do{
        win_side = judge(board,turn);
        turn_change(&turn);
    }while(win_side == 0);
    
    print_board(board);
    win_message(win_side);
    return 0;
}