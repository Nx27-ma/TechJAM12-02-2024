using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private float ScreenWidth = Screen.width / Screen.dpi;
    private float ScreenHeight = Screen.height / Screen.dpi;

    public float ScreenWidth1 { get => ScreenWidth; set => ScreenWidth = value; }
    public float ScreenHeight1 { get => ScreenHeight; set => ScreenHeight = value; }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
