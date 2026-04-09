using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPos;
    public int amountBullets;
    public int bulletType = 1;

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
            if(bulletType != 1)
            {
                Bullet bullet = bulletPrefab.GetComponent<Bullet>();
                bullet.bulletType = this.bulletType; 
            }
            
            Destroy(bulletPrefab, 1);
            amountBullets--;
        }

    }

    public void BulletOne(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            bulletType = 1;
            Debug.Log("Balas en modo: MATAR");
        }
    }

    public void BulletTwo(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            bulletType = 2;
            Debug.Log("Balas en modo: Cambiar de color");
        }
    }
}

