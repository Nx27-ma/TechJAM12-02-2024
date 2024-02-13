using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject SpriteEnemy;
    GameObject[,] enemyArray;
    float Width;
    float Height;
    int enemyXAmount;
    int enemyYAmount;
    float enemyLocX;
    float enemyLocY;

    public float ScreenWidth { get; private set; }
    public float ScreenHeight { get; private set; }

    void Start()
    {
        ScreenWidth = Screen.width / Screen.dpi;
        ScreenHeight = Screen.height / Screen.dpi;
        Controller controller = GetComponent<Controller>();
        Enemy enemy = GetComponent<Enemy>();
        Width = ScreenWidth * 0.9f;
        Height = ScreenHeight * 0.9f;
        enemyXAmount = 6;
        enemyYAmount = 6;

        enemyLocX = Width / enemyXAmount;
        enemyLocY = Height / enemyYAmount;

        enemyArray = new GameObject[enemyXAmount, enemyYAmount];
        for (int i = 0; i < enemyXAmount; i++)
        {
            for (int j = 0; j < enemyYAmount; j++)
            {
                Debug.Log(i);
                Debug.Log(j);
                //enemyLocX = Width / enemyXAmount * i;
                //enemyLocY = Height / enemyYAmount * j;
                //enemyArray[i, j] = Instantiate(SpriteEnemy, new Vector3(enemyLocX, enemyLocX, 0), Quaternion.identity);
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
