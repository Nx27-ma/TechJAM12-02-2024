using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Update()
    {
        StartCoroutine(bullet());
    }

    void bullet()
    {


        yield return new WaitForSeconds(.1f);
    }

}
