#include <stdio.h>
#include "gomoku.h"

// 水平方向に勝敗が決定しているか判定する関数
// 勝敗結果を返す。
int horizontal_judge(int board[BOARD_SIZE][BOARD_SIZE],int turn){
    int x,y;
    int count;
    for(y=0;y<BOARD_SIZE;y++){
        for(x=0;x<BOARD_SIZE-WIN_LENGTH+1;x++){
            if(board[y][x] == turn){
                for(count = 1;count < WIN_LENGTH;count++){
                    if(board[y][x+count] != turn)
                        break;
                }
                if(count == WIN_LENGTH){
                    return turn;
                }
            }
        }
    }
    return 0;
}

// 垂直方向に勝敗が決定しているか判定する関数
// 勝敗結果を返す。
int vertical_judge(int board[BOARD_SIZE][BOARD_SIZE],int turn){
    int x,y;
    int count;
    for(x=0;x<BOARD_SIZE;x++){
        for(y=0;y<BOARD_SIZE-WIN_LENGTH+1;y++){
            if(board[y][x] == turn){
                for(count = 1;count < WIN_LENGTH;count++){
                    if(board[y+count][x] != turn)
                        break;
                }
                if(count == WIN_LENGTH){
                    return turn;
                }
            }
        }
    }
    return 0;
}

// 左上から右下へかけて勝敗が決定しているか判定する関数
int lt_to_rd_judge(int board[BOARD_SIZE][BOARD_SIZE],int turn){
    int x,y;
    int count;
    for(x=0;x<BOARD_SIZE-WIN_LENGTH+1;x++){
        for(y=0;y<BOARD_SIZE-WIN_LENGTH+1;y++){
            if(board[y][x] == turn){
                for(count = 1; count < WIN_LENGTH; count++){
                    if(board[y+count][x+count] != turn)
                        break;
                }
                if(count == WIN_LENGTH){
                    return turn;
                }
            }
        }
    }
    return 0;
}

// 右上から左下へかけて勝敗が決定しているか判定する関数
int rt_to_ld_judge(int board[BOARD_SIZE][BOARD_SIZE],int turn){
    int x,y;
    int count;
    for(x=WIN_LENGTH-1;x<BOARD_SIZE;x++){
        for(y=0;y<BOARD_SIZE-WIN_LENGTH+1;y++){
            if(board[y][x] == turn){
                for(count = 1;count < WIN_LENGTH;count++){
                    if(board[y+count][x-count] != turn)
                        break;
                }
                if(count == WIN_LENGTH){
                    return turn;
                }
            }
        }
    }
    return 0;
}


// int judge(int board[][],int turn)
// 勝敗判定する関数
// return:
// 0 : 勝敗が決定していない状態
// BLACK : 黒が勝利
// WHITE : 白が勝利
// input:
// board : 盤面情報
// turn : 手番
int judge(int board[BOARD_SIZE][BOARD_SIZE],int turn){
    hit_a_piece(board,turn);
    int h = horizontal_judge(board,turn);
    int v = vertical_judge(board,turn);
    int lt_rd = lt_to_rd_judge(board,turn);
    int rt_ld = rt_to_ld_judge(board,turn);
    if(h != 0 || v != 0 || lt_rd != 0 || rt_ld != 0){
        return turn;
    }else{
        return 0;
    }
}