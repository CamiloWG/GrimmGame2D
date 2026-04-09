using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPos;
    public int amountBullets;

    // Start is called before the first frame update
    void Start()
    {
        amountBullets = 3;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if(context.started && amountBullets > 0)
        {
            GameObject bulletPrefab = Instantiate(bullet, shootPos.position, shootPos.rotation);
            Destroy(bulletPrefab, 1);
            amountBullets--;
        }

    }
}
