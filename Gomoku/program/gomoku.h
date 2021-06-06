#define BOARD_SIZE 13
#define WIN_LENGTH 5
#define BLACK 1
#define WHITE -1

// --- prototype ---
void print_board(int[BOARD_SIZE][BOARD_SIZE]);
void hit_a_piece(int[BOARD_SIZE][BOARD_SIZE],int);
void turn_change(int*);
int judge(int[BOARD_SIZE][BOARD_SIZE],int);
void win_message(int);