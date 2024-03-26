using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class boss_walk : StateMachineBehaviour
{   Transform player;
    Rigidbody2D rb; 
    public float Speed = 1f;
    boss boss;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<boss>();
    }

     
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       Vector2 target =new Vector2(player.position.x, rb.position.y);
        Vector2 newpos = Vector2.MoveTowards(rb.position, target, Speed * Time.fixedDeltaTime);
        rb.MovePosition(newpos);
        boss.flipmonster();
      if( Vector2.Distance(player.position, rb.position) <= 10f && Vector2.Distance(player.position, rb.position) >8f)
        {
            animator.SetTrigger("attack");

        }
        if (Vector2.Distance(player.position, rb.position) <= 8f)
        {
            animator.SetTrigger("jump");
        }

    }

     
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("attack");
        animator.ResetTrigger("jump");
    }


}
