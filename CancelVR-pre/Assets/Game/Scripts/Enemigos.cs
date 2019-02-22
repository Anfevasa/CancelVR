using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{

    public GameObject Enemy;
    public GameObject EnemyL2;
    public GameObject EnemyL3;


    public GameObject cam;
    public GameObject Controller;


    Vector3 rndvector;

    public bool shootAble = true;
    public float SpawnInterval = 2.5f;
    public float Speed = 3.0f;
    public Niveles niveles;
    public int nivel;
    public Transform PlayerPos;

    private float x;
    private float y;
    private float z;


    private void Start()
    {
        Controller = GameObject.Find("GameController");
        niveles = Controller.GetComponent<Niveles>();
        nivel = niveles.nivel;

        if (nivel == 2) {
            SpawnInterval = 0.2f;
        }
        if (nivel == 3)
        {
            SpawnInterval = 0.35f;
        }
    }

    private void Update()
    {
        x = PlayerPos.position.x + Random.Range(-20f, 20f);
        y = PlayerPos.position.y + Random.Range(-20f, 20f);
        z = PlayerPos.position.z + Random.Range(-20f, 20f);

        if (shootAble)
        {
            shootAble = false;

            rndvector = new Vector3(x, y, z);

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
        var Enemigo = Instantiate(Enemy, rndvector, Quaternion.EulerAngles(4.7f, y, 0));        
        Enemy.GetComponent<Rigidbody>().velocity = Enemy.transform.forward * Speed;
        

        if  (nivel > 1)
        {
            
            x = PlayerPos.position.x + Random.Range(-20f, 20f);
            y = PlayerPos.position.y + Random.Range(-20f, 20f);
            z = PlayerPos.position.z + Random.Range(-20f, 20f);

            rndvector = new Vector3(x, y, z);

            var EnemigoL2 = Instantiate(EnemyL2, rndvector, Quaternion.EulerAngles(4.7f, y, 0));
            EnemyL2.GetComponent<Rigidbody>().velocity = EnemyL2.transform.forward * Speed;

        }


        if (nivel > 2)
        {

            x = PlayerPos.position.x + Random.Range(-20f, 20f);
            y = PlayerPos.position.y + Random.Range(-20f, 20f);
            z = PlayerPos.position.z + Random.Range(-20f, 20f);

            rndvector = new Vector3(x, y, z);

            var EnemigoL3 = Instantiate(EnemyL3, rndvector, Quaternion.EulerAngles(4.7f, y, 0));
            EnemyL3.GetComponent<Rigidbody>().velocity = EnemyL3.transform.forward * Speed;

        }


    }

    
}
