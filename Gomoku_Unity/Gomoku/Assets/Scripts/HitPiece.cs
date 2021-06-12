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
                
            }
        }
    }
}
