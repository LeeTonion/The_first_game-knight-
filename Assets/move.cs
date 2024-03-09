using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class move : MonoBehaviour
{  
    public float trai_phai;
    public float speed;
    public float high;
    private Animator animator;
    private Rigidbody2D rb;
    private bool a = true;
    public LayerMask groundLayer;
    private BoxCollider2D coll;
    
   
   public void flip()
    {
        if (a && trai_phai < 0 || !a && trai_phai > 0)
        {
            a = !a;
            Vector3 flips = transform.localScale;
            flips.x = flips.x * -1;
            transform.localScale = flips;
        }
    }
   
   
     
    
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        trai_phai = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(trai_phai * speed, rb.velocity.y);
        flip();
        animator.SetFloat("run", Mathf.Abs(trai_phai));
        

         if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded())
        {
            rb.AddForce(Vector2.up * high, ForceMode2D.Impulse);
         
            
        }
       
        bool isGrounded()
        {
           return  Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, groundLayer);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("vatthe"))
        {

            Destroy(this.gameObject);
        }
    }
}