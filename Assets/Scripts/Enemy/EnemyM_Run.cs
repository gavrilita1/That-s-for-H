using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyM_Run : StateMachineBehaviour
{
    public float speed = 2.0f;
    public float attackRange = 3.5f;
     
    Transform player;
    EnemyM enemyM;
    Rigidbody2D rb;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        enemyM = animator.GetComponent<EnemyM>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        enemyM.LookAtPlayer();
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
<<<<<<< HEAD:Assets/Scripts/Enemy/EnemyM_Run.cs
        if ((Vector2.Distance(player.position, rb.position) <= distanceToPlayer) || playerFinded==true)
        {
            playerFinded=true;
            rb.MovePosition(newPos);
        }
=======
        rb.MovePosition(newPos);

>>>>>>> parent of 594c6a3... Semifinal:Assets/EnemyM_Run.cs
        if (Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            animator.SetTrigger("Attack");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }

}
