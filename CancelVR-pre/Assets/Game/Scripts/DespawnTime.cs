using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnTime : MonoBehaviour
{


    public int despawnTime = 6;
    public Rigidbody rb;
    public Vector3 rndvector;
    public float vel = 3.0f;
    

    void start()
    {
        rb.AddForce(rndvector * vel);
        
        

    }

    private void Awake()
    {
        rndvector = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
       // rb.AddForce(rndvector * vel);

        Destroy(gameObject, despawnTime);
        rb.velocity = rndvector*vel;

    }

}
