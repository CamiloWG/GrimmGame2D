using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rb;
    public int bulletType = 1;

    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            if(bulletType == 1)
            {
                Destroy(collider.gameObject);    
            } else if(bulletType == 2)
            {
                SpriteRenderer enemySprite = collider.GetComponent<SpriteRenderer>();
                enemySprite.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);            
            }
            
        }
        else if (collider.gameObject.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
    }
}
