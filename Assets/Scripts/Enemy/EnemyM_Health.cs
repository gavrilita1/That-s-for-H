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
        health_Bar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }
    }

<<<<<<< HEAD:Assets/Scripts/Enemy/EnemyM_Health.cs
    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        if (hitInfo.gameObject.tag.Equals("Arrow"))
        {
            TakeDamageEnemy(30);
            Destroy(hitInfo.gameObject);
        }
    }

=======
>>>>>>> parent of 594c6a3... Semifinal:Assets/EnemyM_Health.cs
    void Die()
    {
        animator.SetBool("IsDead", true);
        GetComponent<Rigidbody2D>().mass = 0;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        this.enabled = false;
    }

}