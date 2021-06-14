using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowResult : MonoBehaviour
{
    Text winmessage;
    // Start is called before the first frame update
    void Start()
    {
        winmessage = this.GetComponent<Text>();
        GameObject result = GameObject.Find("ScoreData");
        DataCarry dc = result.GetComponent<DataCarry>();
        if(dc.result == 1){
            winmessage.text = "黒番の勝ち！";
        }else if(dc.result == -1){
            winmessage.text = "白番の勝ち！";
        }else{
            winmessage.text = "引き分け！";
        }
        // 繰り返しプレーした時にScoreDataが複数生成されてしまうため、
        // それを回避するためのオブジェクト破棄
        Destroy(result);
    }
}
