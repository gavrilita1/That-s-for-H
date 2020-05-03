using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBull_Health : MonoBehaviour
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
        Debug.Log("BOSS  " + health);

        if (health <= 0)
        {
            GetComponent<Animator>().SetBool("IsDead", true);
        }

        health_Bar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Boss Dead");
        animator.SetBool("IsDead", true);
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        GetComponent<Rigidbody2D>().mass = 0;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        this.enabled = false;
        //Destroy(gameObject);
    }

}