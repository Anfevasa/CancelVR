using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject theBullet;
    public Transform barrelEnd;

    public int bulletSpeed;
    public float despawnTime = 3.0f;

    public bool shootAble = true;
    public float waitBeforeNextShot = 0.25f;

    public CardboardControl cardboard;

    private void Start()
    {
        cardboard.trigger.OnClick += CardboardClick;
    }

    private void CardboardClick(object sender)
    {
        var bullet = Instantiate(theBullet, barrelEnd.position, barrelEnd.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        Destroy(bullet, despawnTime);

    }

    //    private void Update()
    //{
    //    if (Input.GetKey(KeyCode.Mouse0))
    //    {
    //        if (shootAble)
    //        {
    //            shootAble = false;
    //            Shoot();
    //            StartCoroutine(ShootingYield());
    //        }
    //    }
    //}

    
}