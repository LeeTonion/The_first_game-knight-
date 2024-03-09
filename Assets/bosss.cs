using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosss : MonoBehaviour
{
    public float jumprange = 1f;
    public LayerMask abc;
    public Transform box;
    public GameObject gameObject;
   
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void monsterjump()
    {
        Collider2D coll = Physics2D.OverlapCircle(box.position, jumprange, abc);
        if (coll != null)
        {
            gameObject.SetActive (true);
        }
        
       
    }
    private void OnDrawGizmosSelected()
    {
        if (box == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(box.position, jumprange);
    }


    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time); 

        gameObject.SetActive(true);
        
    }
}
    

