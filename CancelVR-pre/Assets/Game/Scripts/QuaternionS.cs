using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionS : MonoBehaviour
{

    public GameObject totem;
    private Vector3 inicio;
    //public float rot = 4.8f ;

    // Use this for initialization
    void Start()
    {
        inicio = new Vector3(0f, 0f, 0f);
        Instantiate(totem, inicio, Quaternion.EulerAngles(4.7f,0,0));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
