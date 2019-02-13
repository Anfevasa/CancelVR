using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotate : MonoBehaviour {
    // Speed multiplier
    public float speedMultiplier;

    // Update is called once per frame
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Sets the float value of "_Rotation", adjust it by Time.time and a multiplier.
        GetComponent<Skybox>().material.SetFloat("_Rotation", Time.time * speedMultiplier);

    }
}
