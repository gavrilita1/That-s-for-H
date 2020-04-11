using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBull : MonoBehaviour
{

    public int health;
    public float speed;

    private Animator anim;
    public GameObject bloodEffect;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }

    public void TakeDamageEnemy(int damage)
    {
        //Instantiate(bloodEffect, transform.position, Quaternion.identity);
        health = health - damage;
        Debug.Log("damage Taken " + health);
    }
}
