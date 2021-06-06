OBJS = main.o print_board.o hit_a_piece.o turn_change.o judge.o win_message.o
CC = gcc

# Compiler
Gomoku: $(OBJS)
	$(CC) -Wall -O2 -o $@ $(OBJS)
# Object Files
main.o: main.c
	$(CC) -c $<
print_board.o: print_board.c
	$(CC) -c $<
hit_a_piece.o: hit_a_piece.c
	$(CC) -c $<
turn_change.o: turn_change.c
	$(CC) -c $<
judge.o: judge.c
	$(CC) -c $<
win_message.o: win_message.c
	$(CC) -c $<