using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

	public Vector3 direction;

	public float speed;

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
