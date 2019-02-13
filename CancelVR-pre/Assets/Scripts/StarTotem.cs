using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StarTotem  : MonoBehaviour
{
    public float RotationSpeed = 1;
    private float timer = 0.0f;
    private float crono;
    int seconds = 0;
    public GameObject Totem;
    void Start() {
        Totem.transform.localScale = new Vector3(0F, 0F, 0F);
    }
    void Update()
    {
        timer += Time.deltaTime;
        crono = timer % 60;
        seconds = (int)crono;

        if (seconds > 8)
        {
           Totem.SetActive(true);

            if (seconds < 10)
            {
                Totem.transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);
            }
            
           
        }
        // Rotate the object around its local X axis at 1 degree per second
        //transform.Rotate(Vector3.right * Time.deltaTime);

        // ...also rotate around the World's Y axis


    }

}