using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowSliderValue : MonoBehaviour
{
    public Text textObj;
    public GameObject carry;
    DataCarry script;
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        script = carry.GetComponent<DataCarry>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateValue(){
        textObj.text = ""+slider.value;
        script.cwin = slider.value;
    }

    public void UpdateBoardNum(){
        float v = slider.value+1.0f;
        textObj.text = ""+v;
        script.bsize = slider.value;
    }
}
