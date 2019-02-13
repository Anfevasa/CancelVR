using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{

    public GameObject Enemy;
    public GameObject cam;


    Vector3 rndvector;

    public bool shootAble = true;
    public float SpawnInterval = 2.5f;
    public float Speed = 3.0f;


    private void Update()
    {


        if (shootAble)
        {
            shootAble = false;

            rndvector = new Vector3(Random.Range(-35.0f, 9.0f), Random.Range(1.0f, 43.0f), Random.Range(-60.0f, -14.0f));

            Shoot();
            StartCoroutine(ShootingYield());

        }

    }

    IEnumerator ShootingYield()
    {
        yield return new WaitForSeconds(SpawnInterval);
        shootAble = true;

    }
    void Shoot()
    {

        var Enemigo = Instantiate(Enemy, rndvector, Quaternion.EulerAngles(4.7f, 0, 0));
        Enemy.GetComponent<Rigidbody>().velocity = Enemy.transform.forward * Speed;


    }
}
