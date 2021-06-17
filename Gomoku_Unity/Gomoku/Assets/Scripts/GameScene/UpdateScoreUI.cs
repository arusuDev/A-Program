using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreUI : MonoBehaviour
{
    private DataCarry DCarry;
    private Text SData;
    // Start is called before the first frame update
    void Start()
    {
        DCarry = GameObject.Find("ScoreData").GetComponent<DataCarry>();
        SData = GameObject.Find("NowScore").GetComponent<Text>();
        SData.text = "現在のスコア\n黒"+DCarry.BWin + " - 白"+DCarry.WWin;
    }
}
