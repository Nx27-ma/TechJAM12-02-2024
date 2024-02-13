using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private bool IsMovingRight = true;

    public Transform checkedleft;    public Transform checkedright;    public Transform checkerleft;    public Transform checkerright;

    private void Update()
    {
        if (IsMovingRight)
        {
            transform.Translate(Vector2.right * 12f * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * 12f * Time.deltaTime);
        }
    }
}
