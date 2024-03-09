using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thiênthạch : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 thiênthach = new Vector2(-1, -1).normalized;
        transform.Translate(thiênthach * speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("topographic"))
        {

            Destroy(gameObject);
        }
    }
}
