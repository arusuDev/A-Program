#include <stdio.h>
#include "gomoku.h"

// void win_message(int)
// �������b�Z�[�W�̕\��
// input : ���������T�C�h
void win_message(int turn){
    if(turn == BLACK){
        printf("���Ԃ̏����I\n");
    }else if(turn == WHITE){
        printf("���Ԃ̏����I\n");
    }else{
        printf("���������I\n");
    }
}