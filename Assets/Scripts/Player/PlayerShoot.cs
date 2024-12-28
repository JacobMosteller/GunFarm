using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    
    public Transform firePoint1;
    public Transform firePoint2;
    public GameObject bulletPrefab;
    public GameObject waterGun;
    public GameObject pistol;
    public float gunNumber = 0;

    public float bulletForce = 20f;

    // Update is called once per frame
    private void Start()
    {
        
    }
    void Update()
    {
        ChangeGun();
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if(gunNumber == 0)
        {
            waterGun.SetActive(false);
            pistol.SetActive(true);
        }
        if (gunNumber == 1)
        {
            waterGun.SetActive(true);
            pistol.SetActive(false);
        }
    }

    void Shoot()
    {
        if (gunNumber == 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint1.up * bulletForce, ForceMode2D.Impulse);
        }
        if (gunNumber == 1)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
        }
    }
    void ChangeGun()
    {
        if (Input.GetKeyDown("1"))
        {
            gunNumber = 0;
        }
        if (Input.GetKeyDown("2"))
        {
            gunNumber = 1;
        }
    }
}
