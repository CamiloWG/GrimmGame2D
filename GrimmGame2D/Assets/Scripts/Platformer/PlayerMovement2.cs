using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

    private Rigidbody2D _rd;
    private NewInput _newInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.score = 0;
        _rd = GetComponent<Rigidbody2D>();
        _newInput = GetComponent<NewInput>();
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
    }
}
