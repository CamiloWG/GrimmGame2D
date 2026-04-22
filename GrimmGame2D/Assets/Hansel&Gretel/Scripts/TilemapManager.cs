using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapManager : MonoBehaviour
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
        if(collision.CompareTag("Player"))
        {
            GameObject player = collision.gameObject;
            player.GetComponent<PlayerInfo>().isAlive = false;
            
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            rb.bodyType = RigidbodyType2D.Static;

            player.GetComponent<Animator>().SetTrigger("playerDeath");

            StartCoroutine(BajarJugador(player.transform));
        }
    }

    IEnumerator BajarJugador(Transform playerTransform)
    {
        Vector3 destino = playerTransform.position + new Vector3(0, -1f, 0);
        
        while (Vector3.Distance(playerTransform.position, destino) > 0.01f)
        {
            playerTransform.position = Vector3.MoveTowards(playerTransform.position, destino, 3f * Time.deltaTime);
            yield return null;
        }
    }
}
