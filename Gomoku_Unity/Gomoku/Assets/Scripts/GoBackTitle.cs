using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackTitle : MonoBehaviour
{
    public void OnClickButton(){
        SceneManager.LoadScene("StartMenu");
    }
}
