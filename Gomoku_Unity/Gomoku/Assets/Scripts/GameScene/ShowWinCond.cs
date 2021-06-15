using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowWinCond : MonoBehaviour
{
    Text winCond;
    // Start is called before the first frame update
    void Start()
    {
        GameObject param = GameObject.Find("ScoreData");
        if(param != null){
            DataCarry dc = param.GetComponent<DataCarry>();
            winCond = gameObject.GetComponent<Text>();
            winCond.text = "勝利条件\n"+(int)dc.cwin +"目";
        }
    }
}
