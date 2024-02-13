using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Projectile laserPrefab;
    private float speed = 5f;
    private TextHp textHP;
    void Start()
    {
        textHP = GetComponent<TextHp>();
    }
    void Update()
    {
        Vector2 zoomies = new Vector2(Input.GetAxis("Horizontal"), 0);
        goZoomies(zoomies);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    void goZoomies(Vector2 Pzoomies)
    {
        transform.Translate(Pzoomies * Time.deltaTime * speed, Space.World);
    }

    void Shoot()
    {
        Instantiate(laserPrefab, transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        Debug.Log("hit");
        if (collision.gameObject.CompareTag("EnemyLaser"))
        {
            textHP.health--;
            Destroy(collision.gameObject);
        }
    }
}
