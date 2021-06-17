using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// クリックされた時に盤面を再読込するボタン
/// </summary>
public class RestWorld : MonoBehaviour
{
    public enum WorldNum{
        Title,
        Game
    }

    public WorldNum World;
    // 今のワールドを
    public void ResetWorld(){
        if(World == 0){
            GameObject result = GameObject.Find("ScoreData");
            Destroy(result);
            SceneManager.LoadScene("StartMenu");
        }else{
            SceneManager.LoadScene("MainGameScene");
        }
    }
}
