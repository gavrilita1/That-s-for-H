using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;
    public float runSpeed;
    public float runSpeed2;
    bool jump = false;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;
    public int armour;
    public bool IsBlocking;
    public int health_player;
    public int maxHealth;
    public HealthBar health_Bar;
    public ArmourBar armour_Bar;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    


<<<<<<< HEAD:Assets/Scripts/Players/PlayerMovement.cs
=======
    

>>>>>>> parent of 594c6a3... Semifinal:Assets/Scripts/PlayerMovement.cs
    void Update()
    {
        //health_player = maxHealth;
        //maxHealth = health_player;
        //health_Bar.SetMaxHealth(maxHealth);

        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));



        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
           // animator.SetBool("IsHurt", false);
        }

        if (Input.GetButtonDown("Block"))
        {
            //block = true;

            IsBlocking = true;
            runSpeed = 0;
            animator.SetBool("IsBlocking", true);
            //animator.SetBool("IsHurt", false);
        }

        if (Input.GetButtonUp("Block"))
        {
            IsBlocking = false;
            runSpeed = runSpeed2;
            animator.SetBool("IsBlocking", false);
            //animator.SetBool("IsHurt", false);
        }

        if (Time.time >= nextAttackTime)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                animator.SetBool("IsAttacking", true);
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyM_Health>().TakeDamageEnemy(damage);
                    //enemiesToDamage[i].GetComponent<BossBull_Health>().TakeDamageEnemy(damage);
                }
                nextAttackTime = Time.time + 1f / attackRate;
            }

            if (Input.GetButtonDown("Fire2"))
            {
                animator.SetBool("IsAttacking2", true);
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                   //enemiesToDamage[i].GetComponent<EnemyM_Health>().TakeDamageEnemy(damage);
                    enemiesToDamage[i].GetComponent<BossBull_Health>().TakeDamageEnemy(damage);
                }
                enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyM_Health>().TakeDamageEnemy(damage);
                }
<<<<<<< HEAD:Assets/Scripts/Players/PlayerMovement.cs
                enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
=======
>>>>>>> parent of 594c6a3... Semifinal:Assets/Scripts/PlayerMovement.cs
                nextAttackTime = Time.time + 1f / attackRate;
            }
            
        }
        
        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("IsAttacking", false);
        }

        if (Input.GetButtonUp("Fire2"))
        {
            animator.SetBool("IsAttacking2", false);
        }
    }

    public void TakeDamage(int damage)
    {
<<<<<<< HEAD:Assets/Scripts/Players/PlayerMovement.cs

        if (IsBlocking == true && armour >= 0)
=======
        //Instantiate(bloodEffect, transform.position, Quaternion.identity);
        

        if (IsBlocking == true && armour>=0)
>>>>>>> parent of 594c6a3... Semifinal:Assets/Scripts/PlayerMovement.cs
        {
            armour = armour - damage;
            Debug.Log("BLOCK " + armour);
            armour_Bar.SetHealth(armour);
        }
        else
        {
            animator.SetTrigger("Hurt");
            health_player = health_player - damage;
            Debug.Log("PLAYER " + health_player);
            health_Bar.SetHealth(health_player);
        }
<<<<<<< HEAD:Assets/Scripts/Players/PlayerMovement.cs
        if (health_player <= 0)
        {
            Die();
            SceneManager.LoadScene("GameOver");
        }
=======
        
        
        if (health_player <= 0)
        {
            Die();
        }
        
        
>>>>>>> parent of 594c6a3... Semifinal:Assets/Scripts/PlayerMovement.cs
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        jump = false;
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    void Die()
    {
        Debug.Log("PLAYER Dead");
        animator.SetBool("IsDead", true);
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
