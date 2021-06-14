using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public partial class game : MonoBehaviour
{
    /// <summary>
    /// Result
    /// </summary>
    void goResult(int winner){
        dataCarry.result = winner;
        SceneManager.LoadScene("Result");
    }
}