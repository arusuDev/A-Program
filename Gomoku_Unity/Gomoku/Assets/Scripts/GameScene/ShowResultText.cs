using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class game : MonoBehaviour
{
    public void showMessage(int result){
        dataCarry = GameObject.Find("ScoreData").GetComponent<DataCarry>();
        dataCarry.result = result;
        if(result == White){
            dataCarry.WWin++;
        }else if(result == Black){
            dataCarry.BWin++;
        }
        winMessage.SetActive(winMessage);
    }
}
