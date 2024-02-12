using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    GameObject Enemy;
    GameObject[,] enemyArray;
    float Width;
    float Height;
    int enemyXAmount;
    int enemyYAmount;
    float MarginWidth;
    float MarginHeight;
    float enemyLocX;
    float enemyLocY;
    void Start()
    {
        Controller controller = GetComponent<Controller>();
        Enemy enemy = GetComponent<Enemy>();
        Width = controller.ScreenWidth1 * 0.9f;
        Height = controller.ScreenHeight1 * 0.9f;
        enemyXAmount = 6;
        enemyYAmount = 6;

        enemyLocX = Width / enemyXAmount;
        enemyLocY = Height / enemyYAmount;

        enemyArray = new GameObject[(int)Width, (int)Height];
        for (int i = 0; i < enemyXAmount; i++)
        {
            for (int j = 0; j < enemyYAmount; j++)
            {
                enemyArray[i, j] = Instantiate(Enemy, );
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
