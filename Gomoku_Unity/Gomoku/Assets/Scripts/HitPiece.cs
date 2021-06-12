using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 駒を盤面に打つクラス
/// </summary>
public partial class game : MonoBehaviour
{
    private Camera cameraObject;
    private RaycastHit hit;
    
    /// <summary>
    /// カメラをSceneから入手する関数
    /// Initで呼びます。
    /// </summary>
    void CameraGet(){
        cameraObject = GameObject.Find("Main Camera").GetComponent<Camera>();
        cameraObject.transform.position = new Vector3((BoardSize-1)/2.0f,BoardSize,(BoardSize-1)/2.0f);
    }

    void ClickObserver(){
        if(Input.GetMouseButtonDown(0)){
            Vector3 offset = new Vector3(Screen.height/(BoardSize+2)/2.0f,Screen.height/(BoardSize+2)/2.0f,0.0f);
            Vector3 mp= Input.mousePosition;
            //マウスのポジションにoffsetを加算してRayに
            Ray ray = cameraObject.ScreenPointToRay(mp + offset);
            // Debug.Log(Input.mousePosition);
            // マウスのポジションからRayを投げて何かにあたったらhitに入れる。
            if(Physics.Raycast(ray,out hit)){
                // x,yの値を取得する
                int x = (int) (hit.collider.gameObject.transform.position.x);
                int z = (int) (hit.collider.gameObject.transform.position.z);

                Debug.Log(x+","+z);
                // 指定した座標に既に駒がある場合は、break
                if(Board[x,z] != None){
                    return;
                }else{
                    // ボードに打つ。
                    Board[x,z] = currentPlayer;
                    if(currentPlayer == Black)
                        Instantiate(GoPieces[0],new Vector3(x-0.5f,0.75f,z-0.5f),Quaternion.identity);
                    else
                        Instantiate(GoPieces[1], new Vector3(x-0.5f, 0.75f, z-0.5f), Quaternion.identity);
                    //ターンを相手に渡す。
                    // 勝敗判定
                    switch (judge())
                    {
                        case Black:
                            Debug.Log("黒の勝ち！");
                            break;
                        case White:
                            Debug.Log("白の勝ち！");
                            break;
                        case Draw:
                            Debug.Log("引き分け！");
                            break;
                        default:
                            break;
                    }
                    currentPlayer *= -1;
                    if(currentPlayer == Black){
                        Debug.Log("黒番です。");
                    }else{
                        Debug.Log("白番です。");
                    }
                }
            }
        }
    }
}
