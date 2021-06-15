using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class game : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// BoardSize+1でボードを作成します。
    /// </summary>
    void MakeBoard()
    {
        for(int i=-1;i<BoardSize+1;i++)
            Instantiate(BoardObjects[1],new Vector3(-1.0f,0.0f,i*1.0f), Quaternion.identity);
        for(int i=0;i<BoardSize;i++){
            Instantiate(BoardObjects[1],new Vector3(1.0f*i,0.0f,-1.0f), Quaternion.identity);
            for(int j=0;j<BoardSize;j++){
                Instantiate(BoardObjects[0],new Vector3(i*1.0f,0.0f,j*1.0f),Quaternion.identity);
            }
            Instantiate(BoardObjects[1],new Vector3(1.0f*i,0.0f,BoardSize*1.0f), Quaternion.identity);
        }
        for(int i=-1;i<BoardSize+1;i++)
            Instantiate(BoardObjects[1],new Vector3(1.0f*BoardSize,0.0f,i*1.0f), Quaternion.identity);
            
    }
}
