using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Rigidbody2D _body;

    public float bounceForce;


    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Enemy"))
        {
            _body.AddForce(transform.up * bounceForce, ForceMode2D.Impulse);
            Destroy(collider.gameObject, 1);
        }
    }
}
