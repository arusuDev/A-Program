// hit_a_piece.c
// arusuDev 2021/6/6
#include "gomoku.h"
#include <stdio.h>

// hit_a_piece�֐�
// �Ֆʂɂ��̃^�[���̃R�}��ł��܂��B
// input:
// 1: �Ֆʏ��
// 2: ���
void hit_a_piece(int board[BOARD_SIZE][BOARD_SIZE],int turn){
    int x,y;
    int flag;
    if(turn == 1){
        printf("����(o)�ł��B");
    }else if(turn == -1){
        printf("����(x)�ł��B");
    }
    printf("\n\n");

    do{
        x = y = -1;
        flag = 0;
        print_board(board);
        printf("�ł������}�X���w�肵�Ă�������(x y) => ");
        scanf("%d %d",&x,&y);
        if(x <= 0 || y <= 0 || x>BOARD_SIZE || y > BOARD_SIZE){
            printf("�Ֆʓ����w�肵�Ă��������B\n");
            flag = 1;
        }
        if(board[y-1][x-1] != 0){
            printf("���ɐ΂��ł���Ă���ꏊ�ɑł��Ƃ͏o���܂���B\n");
            flag = 2;
        }
    }while(flag != 0);
    board[y-1][x-1] = turn; 
}