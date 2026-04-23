using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerInfo>().AddPoints(1);
            AudioController.instance.PlayCoin();
            Destroy(gameObject);
        }
    }
}
