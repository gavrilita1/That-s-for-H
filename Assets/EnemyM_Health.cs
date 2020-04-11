using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyM_Health : MonoBehaviour
{
    public Animator animator;

    public int health = 500;
    public HealthBar health_Bar;

    public GameObject deathEffect;

    public bool isInvulnerable = false;

    public void TakeDamageEnemy(int damage)
    {
        if (isInvulnerable)
            return;
        animator.SetTrigger("Hurt");

        health -= damage;
        Debug.Log("ENEMY  " + health);
        //if (health <= 200)
        //{
        //    GetComponent<Animator>().SetBool("IsEnraged", true);
        //}

        health_Bar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("PLAYER Dead");
        animator.SetBool("IsDead", true);
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        GetComponent<Rigidbody2D>().mass = 0;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        this.enabled = false;
        //Destroy(gameObject);
    }

}