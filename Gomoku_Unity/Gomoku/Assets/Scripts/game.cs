using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 五目並べゲームのメインクラス。
/// </summary>
public partial class game : MonoBehaviour
{
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        ClickObserver();
    }
}
