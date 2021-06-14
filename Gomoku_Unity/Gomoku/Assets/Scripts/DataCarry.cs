using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCarry : MonoBehaviour
{
    public float cwin;
    public float bsize;
    public int result;
    // Start is called before the first frame update
    void Start()
    {
        cwin = 5;
        bsize = 8;
        result = 0;
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
