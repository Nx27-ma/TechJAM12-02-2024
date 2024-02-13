using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Projectile : MonoBehaviour
{

	public Vector3 direction;

	public float speed;

    private void Start()
    {
        transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
    }

    private void Update()
	{
		transform.position += direction * speed * Time.deltaTime;
		Invoke("KillThyself", 5);
	}

	void KillThyself()
	{
		Destroy(gameObject);
	}
}
