using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private float ScreenWidth;
    private float ScreenHeight;

    public float ScreenWidth1 { get => ScreenWidth; set => ScreenWidth = value; }
    public float ScreenHeight1 { get => ScreenHeight; set => ScreenHeight = value; }

    void Start()
    {
        ScreenWidth = Screen.width / Screen.dpi;
        ScreenHeight = Screen.height / Screen.dpi;
    }

    void Update()
    {
        
    }
}
