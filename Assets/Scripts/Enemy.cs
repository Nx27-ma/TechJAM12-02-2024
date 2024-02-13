using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    GameObject EnemyLaser;
    quaternion q;
    private int minInterval = 1;
    private int maxInterval = 20;
    void Start()
    {
        q = new quaternion(90f, 0f, 0f, 0f);
        StartCoroutine(SpawnBullets());
    }

    IEnumerator SpawnBullets()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(UnityEngine.Random.Range(minInterval, maxInterval));

            Instantiate(EnemyLaser, transform.position, q);
        }
    }
}
