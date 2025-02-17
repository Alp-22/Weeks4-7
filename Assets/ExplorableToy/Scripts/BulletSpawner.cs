using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    //Initialize GameObjects
    //Gameobject for the bullet
    public GameObject prefab;
    //Gameobject for the muzzle
    public GameObject prefab2;
    //Gameobject to determine where the muzzle spawns
    public GameObject spawner;
    //Classes for the bullet and muzzle
    public Bullet bullet;
    public Muzzle muzzle;
    int counter;
    //Values to control gun stats
    public bool autoFire = true;
    static int fireRate = 100;
    void Start()
    {
        
    }

    public void changeFire(bool f)
    {
        if (f)
        {
            autoFire = true;
            //Debug.Log(true);
        }
        if (!f)
        {
            autoFire = false;
            //Debug.Log(false);
        }
        //autoFire = f;
    }

    // Update is called once per frame
    void Update()
    {
        //Constantly increase the counter to account for firing rate
        counter++;
        bool fire = Input.GetMouseButtonDown(0);
        if (autoFire == false)
        {
            //Get mouse button down forces you to click for it to activate
            fire = Input.GetMouseButtonDown(0);
        }
        if (autoFire == true)
        {
            //Get mouse button continously fires as long as you hold the mouse button down
            fire = Input.GetMouseButton(0);
        }
        //If the counter is over the fire rate it lets you shoot
        if (fire && counter >= fireRate)
        {
            //Spawns the bullet and muzzle flash
            GameObject bulletGO = Instantiate(prefab, transform.position, transform.rotation);
            bullet = bulletGO.GetComponent<Bullet>();
            GameObject muzzleGO = Instantiate(prefab2, spawner.transform.position, transform.rotation);
            muzzle = muzzleGO.GetComponent<Muzzle>();
            //Set the muzzle's parent to the muzzle spawner to account for rotation
            muzzleGO.transform.parent = spawner.transform;
            //Reset counter to 0 to account for firing delay
            counter = 0;
        }
    }
}
