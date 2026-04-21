using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementGrimm : MonoBehaviour
{

    private Rigidbody2D _rd;
    private NewInputGrimm _newInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.score = 0;
        _rd = GetComponent<Rigidbody2D>();
        _newInput = GetComponent<NewInputGrimm>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }
    //Metodo para moverse
    public void Move()
    {
        _rd.velocity = new Vector2(_newInput.inputX * speed, _rd.velocity.y);
        Flip();
    }

    public void Flip()
    {
        if(_newInput.inputX > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        } else if( _newInput.inputX < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
