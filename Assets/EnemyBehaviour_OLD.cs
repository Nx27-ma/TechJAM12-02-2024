//using System.Collections;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using UnityEngine;

//public class EnemyBehaviour : MonoBehaviour
//{
//    [SerializeField]
//    GameObject SpriteEnemy;
//    GameObject[,] enemyArray;
//    float Width;
//    float Height;
//    int enemyXAmount;
//    int enemyYAmount;
//    float enemyLocXt;
//    float enemyLocYt;

//    public float ScreenWidth { get; private set; }
//    public float ScreenHeight { get; private set; }

//    void Start()
//    {
//        float enemyLocX =1;
//        float enemyLocY =1 ;
//        ScreenWidth = Screen.width;
//        ScreenHeight = Screen.height;
//        Controller controller = GetComponent<Controller>();
//        Enemy enemy = GetComponent<Enemy>();
//        Width = ScreenWidth * 0.9f;
//        Height = ScreenHeight * 0.9f;
//        GameObject enemyEnemy = new GameObject("Enemies");
//        enemyXAmount = 6;
//        enemyYAmount = 6;

//        enemyLocXt = ScreenWidth / enemyXAmount;
//        enemyLocYt = ScreenHeight / enemyYAmount;

//        enemyArray = new GameObject[enemyXAmount, enemyYAmount];
//        Debug.Log(enemyArray);
//        for (int i = 0; i < enemyXAmount; i++)
//        {
//            enemyLocX = enemyLocX + enemyLocXt;
//            for (int j = 0; j < enemyYAmount; j++)
//            {
//                //Debug.Log(i);
//                //Debug.Log(j);
//                Debug.Log(Height + " : " + enemyYAmount + " : " + j + " : " + Height / enemyYAmount * j);
//                enemyLocY = enemyLocY + enemyLocYt;
//                enemyArray[i, j] = Instantiate(SpriteEnemy, new Vector3(enemyLocX, enemyLocY, 0), Quaternion.identity);
//                enemyArray[i, j].transform.parent = enemyEnemy.transform;
//            }
//        }
        
//    }

//    void Update()
//    {

//    }

//    void Actualbehaviour()
//    {

//    }
//}
