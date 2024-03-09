using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class attack : MonoBehaviour
{
    public Animator animator;
   
    public float a = 5f;
    public LayerMask enemylayer;
    public Transform gameoject;
    int Damage=5;
    float nextattack;
    public int nextdamage=2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (Time.time >= nextattack) { 
            if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
                nextattack = Time.time + 1/nextdamage;
        }
        }
       
    }
    void Attack()
    {
        animator.SetTrigger("attack");
        
 Collider2D[] list=Physics2D.OverlapCircleAll(gameoject.position, a, enemylayer);
        foreach(Collider2D monster in  list)
        {
            monster.GetComponent<attackmonster>().damageattack(Damage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (gameoject == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(gameoject.position, a);
    }
}
