using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAnim : MonoBehaviour
{
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entro");
        _anim.SetBool("nearBySpider", true);
    }
}
