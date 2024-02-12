using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    GameObject[,] enemyArray;
    float Width;
    float Height;
    int enemyXAmount;
    int enemyYAmount;
    float MarginWidth;
    float MarginHeight;
    void Start()
    {
        Controller controller = GetComponent<Controller>();
        Enemy enemy = GetComponent<Enemy>();
        Width = controller.ScreenWidth1;
        Height = controller.ScreenHeight1;
        MarginWidth = Width / (float)0.9;
        MarginHeight = Height / (float)0.9;
        enemyXAmount = 6;
        enemyYAmount = 6;

        enemyArray = new GameObject[(int)Width, (int)Height];
        for (int i = 0; i < enemyXAmount; i++)
        {
            for (int j = 0; j < enemyYAmount; j++)
            {
                enemyArray[i, j] = new GameObject();
            }
        }
    }

    void Update()
    {
        
    }

    void Actualbehaviour()
    {

    }
}
