using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackmonster : MonoBehaviour
{
    public int maxblood = 100;
    public int blood;
    public Animator animator;
    public healthbar he;
    void Start()
    {
        blood = maxblood;
        he.maxhealth(blood);
    }

   public void damageattack(int Damage)
    { 
        blood-=Damage;
        he.health(blood);
        animator.SetTrigger("hit");
        if (blood <= 0) {
            Die();
        }

    }void Die()
    {
        animator.SetBool("death", true);
        this.enabled = false;
        this.GetComponent<Collider2D>().enabled = false;
        GetComponent<Rigidbody2D>().isKinematic = true;
    }
}
