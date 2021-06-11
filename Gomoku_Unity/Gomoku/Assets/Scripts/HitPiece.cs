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
    }

    void ClickObserver(){
        if(Input.GetMouseButtonDown(0)){
            //マウスのポジションを取得してRayに
            Ray ray = cameraObject.ScreenPointToRay(Input.mousePosition);
            // Debug.Log(Input.mousePosition);
            // マウスのポジションからRayを投げて何かにあたったらhitに入れる。
            if(Physics.Raycast(ray,out hit)){
                // x,yの値を取得する
                // ここにoffsetを入力すると取得したオブジェクトのxを指定するから小数点は無視される。
                int x = (int) (hit.collider.gameObject.transform.position.x);
                int z = (int) (hit.collider.gameObject.transform.position.z);

                Debug.Log(x+","+z);
                
            }
        }
    }
}
