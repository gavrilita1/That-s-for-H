using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyM_Weapon : MonoBehaviour
{
    public int attackDamage = 20;
    public int enragedAttackDamage = 40;

    public Vector3 attackOffset;
    public float attackRange = 1f;
    public LayerMask attackMask;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    public void Attack()
    {
        if (Time.time >= nextAttackTime)
        {
            Vector3 pos = transform.position;
            pos += transform.right * attackOffset.x;
            pos += transform.up * attackOffset.y;

            Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
            if (colInfo != null)
            {
                switch(Random.Range(0,6))
                {
                    case 5:
                        colInfo.GetComponent<PlayerMovement>().TakeDamage(attackDamage*2);
                        Debug.Log("ENEMY CRITICAL");
                    break;
                    case 0:
                        colInfo.GetComponent<PlayerMovement>().TakeDamage(attackDamage/2);
                       Debug.Log("ENEMY MISS");
                    break;
                    default:
                        colInfo.GetComponent<PlayerMovement>().TakeDamage(attackDamage);
                    break;
                }
                //colInfo.GetComponent<PlayerMovement>().TakeDamage(attackDamage);
            }
            nextAttackTime = Time.time + 1f / attackRate;
        }
    }

    public void EnragedAttack()
    {
        Vector3 pos = transform.position;   
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;

        Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        if (colInfo != null)
        {
            //colInfo.GetComponent<PlayerHealth>().TakeDamage(enragedAttackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;

        Gizmos.DrawWireSphere(pos, attackRange);
    }
}
