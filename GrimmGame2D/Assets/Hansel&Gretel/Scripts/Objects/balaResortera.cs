using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaResortera : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyMovement>().AttackEnemy();
            Destroy(gameObject);
        } else if (collision.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
    }
}
