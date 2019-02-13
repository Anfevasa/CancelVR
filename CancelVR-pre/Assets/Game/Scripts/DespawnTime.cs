using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnTime : MonoBehaviour
{


    public int despawnTime = 6;
    public bool DestroyAble = false;
    public Rigidbody rb;
    public Vector3 rndvector;
    public float vel = 3.0f;
    public Transform transform1;

    void Start()
    {
        rndvector = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));
        rb.AddForce(rndvector * vel);
        rndvector = new Vector3(90f,0f,0f);
        //transform1.Rotate(rndvector);

    }

    // Update is called once per frame
    void Update()
    {

        Destroy(gameObject, despawnTime);

    }

}
