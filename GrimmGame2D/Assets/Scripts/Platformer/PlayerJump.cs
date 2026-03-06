using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D _rd;
    public float jumpForce;


    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
    }

    // Metodo que permita saltar al personaje
    public void Jump()
    {
        if (Mathf.Abs(_rd.velocity.y) < 0.01)
        {
            _rd.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
