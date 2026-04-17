using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            PlayerShoot playerBullets = collision.GetComponent<PlayerShoot>();
            playerBullets.amountBullets += 10;
            AudioManager.instance.PlayCoin();
            Destroy(gameObject, 1);
        }
    }
}
