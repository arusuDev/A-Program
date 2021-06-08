using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class game : MonoBehaviour
{
    public GameObject[] board = new GameObject[2];
    public int board_size;
    // Start is called before the first frame update
    void MakeBoard()
    {
        for(int i=-1;i<board_size+1;i++)
            Instantiate(board[1],new Vector3(-0.5f,0.0f,i*0.5f), Quaternion.identity);
        for(int i=0;i<board_size;i++){
            Instantiate(board[1],new Vector3(0.5f*i,0.0f,-0.5f), Quaternion.identity);
            for(int j=0;j<board_size;j++){
                Instantiate(board[0],new Vector3(i*0.5f,0.0f,j*0.5f),Quaternion.identity);
            }
            Instantiate(board[1],new Vector3(0.5f*i,0.0f,board_size*0.5f), Quaternion.identity);
        }
        for(int i=-1;i<board_size+1;i++)
            Instantiate(board[1],new Vector3(0.5f*board_size,0.0f,i*0.5f), Quaternion.identity);
            
    }
}
