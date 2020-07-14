using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject arrow;
    public float launchForce;
    public Transform shotPoint;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    // Update is called once per frame
    void Update()
    {
        Vector2 bowPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - bowPosition;
        transform.right = direction;

        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time >= nextAttackTime)
            {
                Shoot();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Shoot()
    {
        GameObject NewArrot = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
        NewArrot.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    }

}
