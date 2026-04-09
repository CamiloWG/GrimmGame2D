using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rb;

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
            Destroy(collider.gameObject);
        }
        else if (collider.gameObject.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
    }
}
