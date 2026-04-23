using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPos;

    public void Shoot()
    {
        GameObject bulletPrefab = Instantiate(bullet, shootPos.position, shootPos.rotation);        
        Destroy(bulletPrefab, 1);
    }

}
