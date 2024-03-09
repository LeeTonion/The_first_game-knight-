using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public bool b = false;
    public Transform player;
    public Transform bosso;
    
    public float attackrange = 1f;
    public LayerMask abc;
    public GameObject abcd;
    
    
    public void monsterattack()
    {
        Collider2D col = Physics2D.OverlapCircle(bosso.position, attackrange, abc);
        if ( col != null)
        {
            Des();
        }
        
    }
   
    private void OnDrawGizmosSelected()
    {
        if (bosso == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(bosso.position, attackrange);
       
    }
    public void flipmonster()

    {
        Vector3 c = transform.localScale;
        c.z *= -1f;
        if (transform.position.x > player.position.x && b)
        {
            transform.localScale = c;
            transform.Rotate(0f, 180f, 0f);
            b = false;

        }
        else if (transform.position.x < player.position.x && !b)
        {
            transform.localScale = c;
            transform.Rotate(0f, 180f, 0f);
            b = true;

        }
    }
   public void Des()
    {
        Destroy(abcd);
    }

}

