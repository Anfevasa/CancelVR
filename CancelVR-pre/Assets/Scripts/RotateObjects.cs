using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RotateObjects : MonoBehaviour
{
    public float RotationSpeed = 1;
   
   
    void Update()
    {
        
            
            transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed, Space.World);
        
        // Rotate the object around its local X axis at 1 degree per second
        //transform.Rotate(Vector3.right * Time.deltaTime);

        // ...also rotate around the World's Y axis
       
       
    }
    
}